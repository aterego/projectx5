using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UserCategoriesRepository :BaseRepository, IUserCategoriesRepository
    {
        public UserCategoriesRepository(MyDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Get User Categories.
        /// </summary>
        /// <param name="userId">Current user ID
        public async Task<IEnumerable<UserCategories>> GetCategoriesAsync(int userId)
        {
            return await _context.UserCategories.Where(u => u.UserId == userId).ToListAsync();
        }

        public async Task AddAsync(UserCategories userCategories)
        {
            await _context.UserCategories.AddAsync(userCategories);
            //await _context.SaveChangesAsync();
        }

        public async Task<UserCategories> FindByUserIdAsync(int userId)
        {
            return await _context.UserCategories.Where(u => u.UserId == userId).FirstOrDefaultAsync();
        }


        public async Task UpdateAsync(UserCategories userCategories)
        {
            _context.UserCategories.Update(userCategories);
            //await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Remove userCategories.
        /// </summary>
        /// <param name="category">Categories class
        public async Task Remove(UserCategories userCategories)
        {
            _context.UserCategories.Remove(userCategories);
            ///await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Remove userCategories by user Id.
        /// </summary>
        /// <param name="userId">user Id
        public async Task RemoveByUser(int userId)
        {
            var items = _context.UserCategories.Where(item => item.UserId == userId);
            _context.UserCategories.RemoveRange(items);
            ///await _context.SaveChangesAsync();
        }


    }
}
