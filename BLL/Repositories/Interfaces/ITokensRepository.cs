using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Repositories
{
    public interface ITokensRepository
    {
        Task AddAsync(Tokens tokens);
        /// <summary>
        /// Remove token.
        /// </summary>
        /// <param name="token">Current token
        void Remove(Tokens token);
        /// <summary>
        /// Get Tokens by string.
        /// </summary>
        /// <param name="token">Current token
        Task<Tokens> GetTokensAsync(string token);
    }
}
