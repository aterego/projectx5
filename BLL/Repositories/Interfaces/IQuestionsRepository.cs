using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public interface IQuestionsRepository
    {
        /// <summary>
        /// Gets List of All Questions.
        /// </summary>
        Task<IEnumerable<Questions>> ListAsync();
    }
}
