using System;

namespace BLL.Security.Tokens
{
    public class AccessToken :JsonWebToken
    {
        public RefreshToken RefreshToken { get; private set; }

        public AccessToken(string token, long expiration, RefreshToken refreshToken, string role) : base(token, expiration, role)
        {
            RefreshToken = refreshToken ?? throw new ArgumentException("Specify a valid refresh token.");
        }

    }
}
