using System.Threading.Tasks;
using userServices.Services.Communication;
using DAL.Models;


namespace userServices.Services
{
    public interface IUsersCustomerService
    {
        Task<CreateUsersCustomerResponse> CreateUserAsync(UsersCustomer usersCustomer);
    }
}
