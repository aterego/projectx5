using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace userServices.Resources
{
    public class QuestionsResource
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Text { get; set; }
        public ICollection<CategoriesResource> Category { get; set; }

    }
}
