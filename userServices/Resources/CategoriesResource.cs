using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace userServices.Resources
{
    public class CategoriesResource
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
