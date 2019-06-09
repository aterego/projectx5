using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class RefRoles
    {
        public RefRoles()
        {
            Admins = new HashSet<Admins>();
            RolesMenus = new HashSet<RolesMenus>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }

        public ICollection<Admins> Admins { get; set; }
        public ICollection<RolesMenus> RolesMenus { get; set; }
    }
}
