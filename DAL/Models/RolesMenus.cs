using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class RolesMenus
    {
        public int Id { get; set; }
        public int RolesId { get; set; }
        public int MenusId { get; set; }

        public Menus Menus { get; set; }
        public RefRoles Roles { get; set; }
    }
}
