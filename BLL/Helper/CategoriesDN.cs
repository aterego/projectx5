using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Helper
{
    public class CategoriesDN
    {
        public Int32 Id { get; set; }
        public Int32 ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float? PriceMin { get; set; }
        public float? PriceMax { get; set; }
  

    }
}
