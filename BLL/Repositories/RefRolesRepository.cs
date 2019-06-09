using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class RefRolesRepository : BaseRepository, IRefRolesRepository
    {
        public RefRolesRepository(MyDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Gets Roles under current role.
        /// </summary>
        /// <param name="roleId">Current role ID
        public async Task<IEnumerable<RefRoles>> ListAsync(int roleId)
        {
            return await _context.RefRoles.Where(x => x.Id >= roleId).ToListAsync();
        }

        /// <summary>
        /// Get Role.
        /// </summary>
        /// <param name="id">Current role ID
        public async Task<RefRoles> GetRolesAsync(int id)
        {
            return await _context.RefRoles.SingleOrDefaultAsync(m => m.Id == id);
        }
        public async Task AddAsync(RefRoles roles)
        {
            await _context.RefRoles.AddAsync(roles);
            await _context.SaveChangesAsync();
        }

        public async Task AddRolesMenusAsync(RolesMenus rolesMenus)
        {
            await _context.RolesMenus.AddAsync(rolesMenus);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(RefRoles roles)
        {
            _context.RefRoles.Update(roles);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Remove Roles.
        /// </summary>
        /// <param name="RefRoles">RefRoles class
        public async Task Remove(RefRoles refRoles)
        {
            _context.RefRoles.Remove(refRoles);
            await _context.SaveChangesAsync();
        }
        /// <summary>
        /// Remove Role-menus.
        /// </summary>
        /// <param name="RolesMenus">RolesMenus class
        public async Task Remove(RolesMenus rolesMenus)
        {
            _context.RolesMenus.Remove(rolesMenus);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Get Menus for Role.
        /// </summary>
        /// <param name="id">Current role ID
        public async Task<List<string>> GetMenus(int id)
        {
            return await _context.RolesMenus.Where(s => s.RolesId == id).Select(s => s.MenusId.ToString()).ToListAsync();
        }

        /// <summary>
        /// Get Roles-Menus for Role.
        /// </summary>
        /// <param name="id">Current role ID
        public async Task<IEnumerable<RolesMenus>> GetRolesMenus(int id)
        {
            return await _context.RolesMenus.Where(s => s.RolesId == id).ToListAsync();
        }

        /// <summary>
        /// Gets list of menus.
        /// </summary>
        public async Task<List<Menus>> ListMenusAsync()
        {
            return await _context.Menus.ToListAsync();
        }

        public async Task<bool> RolesExists(int id)
        {
            return await _context.RefRoles.AnyAsync(e => e.Id == id);
        }

    }
}
