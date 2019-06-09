using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Account
    {
        public Account()
        {
            Transactions = new HashSet<Transactions>();
        }

        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public int UserId { get; set; }
        public sbyte Active { get; set; }
        public DateTime Created { get; set; }

        public Users User { get; set; }
        public AccountBalance AccountBalance { get; set; }
        public ICollection<Transactions> Transactions { get; set; }
    }
}
