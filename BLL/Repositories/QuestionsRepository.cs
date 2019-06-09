using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class QuestionsRepository : BaseRepository, IQuestionsRepository
    {
        public QuestionsRepository(MyDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Gets List of All Questions.
        /// </summary>
        public async Task<IEnumerable<Questions>> ListAsync()
        {
            return await _context.Questions.ToListAsync();
        }


    }
}
