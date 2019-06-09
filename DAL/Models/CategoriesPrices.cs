using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CategoriesPrices
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public float? PriceMin { get; set; }
        public float? PriceMax { get; set; }
        public sbyte Active { get; set; }
        public DateTime Created { get; set; }

        public Categories Category { get; set; }
    }
}
