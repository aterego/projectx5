using System;

namespace BLL.Security.Tokens
{
    public abstract class JsonWebToken
    {
        public string Token { get; protected set; }

        public long Expiration { get; protected set; }

        public string Role { get; protected set; }

        public JsonWebToken(string token, long expiration, string role)
        {
            if (string.IsNullOrWhiteSpace(token))
                throw new ArgumentException("Invalid token.");

            if (expiration <= 0)
                throw new ArgumentException("Invalid expiration.");

            Token = token;
            Expiration = expiration;
            Role = role;
        }

        


        public bool IsExpired() => DateTime.UtcNow.Ticks > Expiration;
    }
}
