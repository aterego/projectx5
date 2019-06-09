using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class QuestionCategories
    {
        public int Id { get; set; }
        public int QId { get; set; }
        public int CategoryId { get; set; }
        public DateTime Created { get; set; }

        public Categories Category { get; set; }
        public Questions Q { get; set; }
    }
}
