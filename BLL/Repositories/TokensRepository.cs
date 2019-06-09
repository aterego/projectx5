using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class TokensRepository:BaseRepository, ITokensRepository
    {

        public TokensRepository(MyDbContext context) : base(context)
        {
        }


        public async Task AddAsync(Tokens token)
        {
            await _context.Tokens.AddAsync(token);
        }

        /// <summary>
        /// Remove token.
        /// </summary>
        /// <param name="token">Current token
        public void Remove(Tokens token)
        {
            _context.Tokens.Remove(token);
        }


        /// <summary>
        /// Get Tokens by string.
        /// </summary>
        /// <param name="token">Current token
        public async Task<Tokens> GetTokensAsync(string token)
        {
            return await _context.Tokens.SingleOrDefaultAsync(t => t.Token == token);
        }
    }
}
