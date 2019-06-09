using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Users
    {
        public Users()
        {
            Account = new HashSet<Account>();
            UserCategories = new HashSet<UserCategories>();
            UserFiles = new HashSet<UserFiles>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int UserType { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastVisited { get; set; }
        public string LastIp { get; set; }

        public RefUserType UserTypeNavigation { get; set; }
        public UsersCustomer UsersCustomer { get; set; }
        public UsersProfi UsersProfi { get; set; }
        public ICollection<Account> Account { get; set; }
        public ICollection<UserCategories> UserCategories { get; set; }
        public ICollection<UserFiles> UserFiles { get; set; }
    }
}
