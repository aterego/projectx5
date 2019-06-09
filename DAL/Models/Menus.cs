using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Menus
    {
        public Menus()
        {
            RolesMenus = new HashSet<RolesMenus>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public int ParentId { get; set; }
        public sbyte IsMenu { get; set; }
        public sbyte IsVisible { get; set; }
        public sbyte Super { get; set; }
        public int Order { get; set; }

        public ICollection<RolesMenus> RolesMenus { get; set; }
    }
}
