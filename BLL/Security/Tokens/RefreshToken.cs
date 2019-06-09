using System;

namespace BLL.Security.Tokens
{
    public class RefreshToken : JsonWebToken
    {
        public RefreshToken(string token, long expiration, string role) : base(token, expiration, role)
        {
        }
    }
}
