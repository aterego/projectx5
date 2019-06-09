using DAL.Models;

namespace userServices.Services.Communication
{
    public class CreateUsersProfiResponse:BaseResponse
    {
        public Users User { get; private set; }
        public UsersProfi UsersProfi { get; private set; }

        public CreateUsersProfiResponse(bool success, string message, Users user, UsersProfi usersProfi) : base(success, message)
        {
            User = user;
            UsersProfi = usersProfi;
        }
    }
}
