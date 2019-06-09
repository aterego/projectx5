using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Repositories
{
    public interface IUsersProfiRepository
    {
        Task AddAsync(UsersProfi usersProfi);
    }
}
