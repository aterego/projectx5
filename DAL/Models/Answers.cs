using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Answers
    {
        public Answers()
        {
            Transactions = new HashSet<Transactions>();
        }

        public int Id { get; set; }
        public int QId { get; set; }
        public int ProfiId { get; set; }
        public string Text { get; set; }
        public sbyte Active { get; set; }
        public sbyte Accepted { get; set; }
        public DateTime Created { get; set; }

        public UsersProfi Profi { get; set; }
        public Questions Q { get; set; }
        public ICollection<Transactions> Transactions { get; set; }
    }
}
