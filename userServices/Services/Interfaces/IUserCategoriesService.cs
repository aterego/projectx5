using System.Threading.Tasks;
using userServices.Services.Communication;
using DAL.Models;
using System.Collections.Generic;

namespace userServices.Services
{
    public interface IUserCategoriesService
    {
        Task<IEnumerable<UserCategories>> GetCategoriesAsync(int userId);
        Task<UserCategoriesResponse> SaveAsync(UserCategories userCategories);
        Task<UserCategoriesResponse> DeleteAsync(int userId);
    }
}
