using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UsersRepository :BaseRepository, IUsersRepository
    {
        public UsersRepository(MyDbContext context) : base(context)
        {
        }

        public async Task AddAsync(Users user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<Users> FindByEmailAsync(string email)
        {
            return await _context.Users.Include(u => u.UserTypeNavigation).Where(u => u.UserTypeNavigation.Id == u.UserType).SingleOrDefaultAsync(u => u.Email == email);
        }

    }
}
