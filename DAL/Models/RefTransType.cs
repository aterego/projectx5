using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class RefTransType
    {
        public RefTransType()
        {
            Transactions = new HashSet<Transactions>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Transactions> Transactions { get; set; }
    }
}
