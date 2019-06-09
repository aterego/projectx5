using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class RefTransSystems
    {
        public RefTransSystems()
        {
            Transactions = new HashSet<Transactions>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }

        public ICollection<Transactions> Transactions { get; set; }
    }
}
