using System.Threading.Tasks;
using DAL.Models;


namespace userServices.Services
{
    public interface IUsersService
    {
        Task<Users> FindByEmailAsync(string email);
    }
}
