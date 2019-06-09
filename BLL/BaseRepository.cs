using DAL.Models;

namespace BLL
{
    public abstract class BaseRepository
    {
        protected readonly MyDbContext _context;

        public BaseRepository(MyDbContext context)
        {
            _context = context;
        }
    }
}
