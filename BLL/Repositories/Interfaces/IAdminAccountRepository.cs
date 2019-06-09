using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Repositories
{
    public interface IAdminAccountRepository
    {
        /// <summary>
        /// Get Admin with corresponding email or username.
        /// </summary>
        /// <param name="Admins">Admins class
        Task<Admins> GetAdminsAsync(Admins admin);
        /// <summary>
        /// Get Menus for corresponding role.
        /// </summary>
        /// <param name="int">role ID
        Task<List<Menus>> GetMenusAsync(int roleId);
    }
}
