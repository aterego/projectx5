using System;
using BLL.Repositories;
using BLL.Security;
using DAL.Models;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.Security.Tokens;

namespace userServices.Services
{
    public class TokenHandler :ITokenHandler
    {
        private readonly ITokensRepository _tokensRepository;
        private readonly IUnitOfWork _unitOfWork;

        private readonly TokenOptions _tokenOptions;
        private readonly SigningConfigurations _signingConfigurations;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IEncryptionHelper _encryptionHelper;

        public TokenHandler(IOptions<TokenOptions> tokenOptionsSnapshot, SigningConfigurations signingConfigurations, IPasswordHasher passwordHasher, IEncryptionHelper encryptionHelper, ITokensRepository tokensRepository, IUnitOfWork unitOfWork)
        {
            _passwordHasher = passwordHasher;
            _encryptionHelper = encryptionHelper;
            _tokenOptions = tokenOptionsSnapshot.Value;
            _signingConfigurations = signingConfigurations;
            _tokensRepository = tokensRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<AccessToken> CreateAccessToken(Users user)
        {
            var refreshToken = BuildRefreshToken(user);
            var accessToken = BuildAccessToken(user, refreshToken);
            var dbrefreshToken = new DAL.Models.Tokens { Token = _encryptionHelper.Encrypt(refreshToken.Token), Expiration = refreshToken.Expiration};
            await _tokensRepository.AddAsync(dbrefreshToken);
            await _unitOfWork.CompleteAsync();

            return accessToken;
        }

        public async Task<RefreshToken> TakeRefreshToken(string token)
        {
            RefreshToken refreshToken = null;


            if (string.IsNullOrWhiteSpace(token))
                return null;

            var dbrefreshToken = await _tokensRepository.GetTokensAsync(_encryptionHelper.Encrypt(token));

            if (dbrefreshToken != null)
            {
                refreshToken = new RefreshToken
                                        (
                                            token: token, //_encryptionHelper.Decrypt(dbrefreshToken.Token),
                                            expiration: dbrefreshToken.Expiration,
                                            role: ""
                                        );

                _tokensRepository.Remove(dbrefreshToken);
                await _unitOfWork.CompleteAsync();
            }


            return refreshToken;
        }

        public async void RevokeRefreshToken(string token)
        {
           await TakeRefreshToken(token);
        }

        private RefreshToken BuildRefreshToken(Users user)
        {
            var refreshToken = new RefreshToken
            (
                token: _passwordHasher.HashPassword(Guid.NewGuid().ToString()),
                expiration: DateTime.UtcNow.AddSeconds(_tokenOptions.RefreshTokenExpiration).Ticks,
                role: user.UserTypeNavigation.Name
            );

            return refreshToken;
        }

        private AccessToken BuildAccessToken(Users user, RefreshToken refreshToken)
        {
            var accessTokenExpiration = DateTime.UtcNow.AddSeconds(_tokenOptions.AccessTokenExpiration);

            var securityToken = new JwtSecurityToken
            (
                issuer: _tokenOptions.Issuer,
                audience: _tokenOptions.Audience,
                claims: GetClaims(user),
                expires: accessTokenExpiration,
                notBefore: DateTime.UtcNow,
                signingCredentials: _signingConfigurations.SigningCredentials
            );

            var handler = new JwtSecurityTokenHandler();
            var accessToken = handler.WriteToken(securityToken);

            return new AccessToken(accessToken, accessTokenExpiration.Ticks, refreshToken, user.UserTypeNavigation.Name);
        }

        private IEnumerable<Claim> GetClaims(Users user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, user.Email)
            };

            claims.Add(new Claim(ClaimTypes.Role, user.UserTypeNavigation.Name));

            return claims;
        }

    }
}
