using DAL.Models;

namespace userServices.Services.Communication
{
    public class CreateUsersCustomerResponse:BaseResponse
    {
        public Users User { get; private set; }
        public UsersCustomer UsersCustomer { get; private set; }

        public CreateUsersCustomerResponse(bool success, string message, Users user, UsersCustomer usersCustomer) : base(success, message)
        {
            User = user;
            UsersCustomer = usersCustomer;
        }
    }
}
