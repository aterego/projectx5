using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Repositories
{
    public interface IUserCategoriesRepository
    {
        /// <summary>
        /// Get User Categories.
        /// </summary>
        /// <param name="userId">Current user ID
        Task<IEnumerable<UserCategories>> GetCategoriesAsync(int userId);
        Task AddAsync(UserCategories userCategories);
        Task<UserCategories> FindByUserIdAsync(int userId);
        Task UpdateAsync(UserCategories userCategories);
        Task Remove(UserCategories userCategories);

        /// <summary>
        /// Remove userCategories by user Id.
        /// </summary>
        /// <param name="userId">user Id
        Task RemoveByUser(int userId);
    }
}
