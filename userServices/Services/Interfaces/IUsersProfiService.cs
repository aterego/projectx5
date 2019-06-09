using System.Threading.Tasks;
using userServices.Services.Communication;
using DAL.Models;


namespace userServices.Services
{
    public interface IUsersProfiService
    {
        Task<CreateUsersProfiResponse> CreateUserAsync(UsersProfi usersProfi);
    }
}
