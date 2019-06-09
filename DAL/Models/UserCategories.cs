using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserCategories
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public DateTime Created { get; set; }

        public Categories Category { get; set; }
        public Users User { get; set; }
    }
}
