using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Repositories
{
    public interface IAdminsRepository
    {
        /// <summary>
        /// Gets Admins under roles.
        /// </summary>
        /// <param name="roleId">Current role ID
        Task<IEnumerable<Admins>> ListAsync(int roleId);
        /// <summary>
        /// Get Admin.
        /// </summary>
        /// <param name="id">Current admin ID
        Task<Admins> GetAdminAsync(int id);
        /// <summary>
        /// Get Admin with roles.
        /// </summary>
        /// <param name="id">Current admin ID
        Task<Admins> GetAdminWithRolesAsync(int id);

        Task AddAsync(Admins admins);
        Task UpdateAsync(Admins admins);
        /// <summary>
        /// Remove admin.
        /// </summary>
        /// <param name="admins">Admins class
        Task Remove(Admins admins);
        Task<bool> AdminsExists(int id);
    }
}
