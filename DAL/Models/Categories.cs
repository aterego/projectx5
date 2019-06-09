using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Categories
    {
        public Categories()
        {
            CategoriesPrices = new HashSet<CategoriesPrices>();
            QuestionCategories = new HashSet<QuestionCategories>();
            UserCategories = new HashSet<UserCategories>();
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }

        public ICollection<CategoriesPrices> CategoriesPrices { get; set; }
        public ICollection<QuestionCategories> QuestionCategories { get; set; }
        public ICollection<UserCategories> UserCategories { get; set; }
    }
}
