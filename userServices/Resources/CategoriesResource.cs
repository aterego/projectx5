using DAL.Models;
using System.Collections.Generic;

namespace userServices.Resources
{
    public class CategoriesResource
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<CategoriesPricesResource> CategoriesPrices { get; set; }
    }
}
