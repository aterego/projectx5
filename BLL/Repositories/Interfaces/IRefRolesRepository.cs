using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Repositories
{
    public interface IRefRolesRepository
    {
        /// <summary>
        /// Gets Roles under current role.
        /// </summary>
        /// <param name="roleId">Current role ID
        Task<IEnumerable<RefRoles>> ListAsync(int roleId);
        /// <summary>
        /// Get Role.
        /// </summary>
        /// <param name="id">Current role ID
        Task<RefRoles> GetRolesAsync(int id);
        Task AddAsync(RefRoles roles);
        Task AddRolesMenusAsync(RolesMenus rolesMenus);
        Task UpdateAsync(RefRoles roles);
        /// <summary>
        /// Remove Roles.
        /// </summary>
        /// <param name="RefRoles">RefRoles class
        Task Remove(RefRoles refRoles);
        /// <summary>
        /// Remove Role-menus.
        /// </summary>
        /// <param name="RolesMenus">RolesMenus class
        Task Remove(RolesMenus rolesMenus);
        /// <summary>
        /// Get Menus for Role.
        /// </summary>
        /// <param name="id">Current role ID
        Task<List<string>> GetMenus(int id);
        /// <summary>
        /// Get Roles-Menus for Role.
        /// </summary>
        /// <param name="id">Current role ID
        Task<IEnumerable<RolesMenus>> GetRolesMenus(int id);
        /// <summary>
        /// Gets list of menus.
        /// </summary>
        Task<List<Menus>> ListMenusAsync();
        Task<bool> RolesExists(int id);
    }
}
