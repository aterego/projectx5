using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class AdminAccountRepository : BaseRepository, IAdminAccountRepository
    {
        public AdminAccountRepository(MyDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Get Admin with corresponding email or username.
        /// </summary>
        /// <param name="Admins">Admins class
        public async Task<Admins> GetAdminsAsync(Admins admin)
        {
            return await _context.Admins.Where(s => s.Email == admin.Email || s.Username == admin.Email).FirstAsync();
        }

        /// <summary>
        /// Get Menus for corresponding role.
        /// </summary>
        /// <param name="int">role ID
        public async Task<List<Menus>> GetMenusAsync(int roleId)
        {
            return await _context.RolesMenus.Where(s => s.RolesId == roleId && (s.Menus.IsMenu == 1)).Select(s => s.Menus).OrderBy(o => o.Order).ToListAsync();
        }

    }
}
