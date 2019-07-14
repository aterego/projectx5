using DAL.Models;
using System;
using System.Collections.Generic;

namespace userServices.Resources
{
    public class CategoriesPricesResource
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public float? PriceMin { get; set; }
        public float? PriceMax { get; set; }
        public sbyte Active { get; set; }
        public DateTime Created { get; set; }

    }
}
