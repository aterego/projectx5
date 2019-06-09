using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class RefUserType
    {
        public RefUserType()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
