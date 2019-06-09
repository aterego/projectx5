using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class QuestionPrice
    {
        public int Id { get; set; }
        public int QId { get; set; }
        public float Price { get; set; }
        public sbyte Active { get; set; }
        public DateTime Created { get; set; }

        public Questions Q { get; set; }
    }
}
