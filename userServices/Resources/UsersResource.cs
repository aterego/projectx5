using System.ComponentModel.DataAnnotations;

namespace userServices.Resources
{
    public class UsersResource
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        //public RefUserType UserTypeNavigation { get; set; }
    }
}
