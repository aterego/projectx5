using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class AdminsRepository : BaseRepository, IAdminsRepository
    {
        public AdminsRepository(MyDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Gets Admins under roles.
        /// </summary>
        /// <param name="roleId">Current role ID
        public async Task<IEnumerable<Admins>> ListAsync(int roleId)
        {
            return await _context.Admins.Where(a => a.Id >= roleId).Include(a => a.Roles).ToListAsync();
        }

        /// <summary>
        /// Get Admin.
        /// </summary>
        /// <param name="id">Current admin ID
        public async Task<Admins> GetAdminAsync(int id)
        {
            return await _context.Admins.SingleOrDefaultAsync(m => m.Id == id);
        }

        /// <summary>
        /// Get Admin with roles.
        /// </summary>
        /// <param name="id">Current admin ID
        public async Task<Admins> GetAdminWithRolesAsync(int id)
        {
            return await _context.Admins
                .Include(a => a.Roles)
                .SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task AddAsync(Admins admins)
        {
            await _context.Admins.AddAsync(admins);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Admins admins)
        {
            _context.Admins.Update(admins);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Remove admin.
        /// </summary>
        /// <param name="admins">Admins class
        public async Task Remove(Admins admins)
        {
            _context.Admins.Remove(admins);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> AdminsExists(int id)
        {
           return  await _context.Admins.AnyAsync(e => e.Id == id);
        }

    }
}
