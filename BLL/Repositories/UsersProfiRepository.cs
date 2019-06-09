using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UsersProfiRepository :BaseRepository, IUsersProfiRepository
    {
        public UsersProfiRepository(MyDbContext context) : base(context)
        {
        }

        public async Task AddAsync(UsersProfi usersProfi)
        {
            await _context.UsersProfi.AddAsync(usersProfi);
            //await _context.SaveChangesAsync();
        }
    }
}
