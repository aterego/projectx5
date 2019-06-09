using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AccountBalance
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public float Available { get; set; }
        public float Blocked { get; set; }
        public int LastTransactionId { get; set; }
        public DateTime LastChanged { get; set; }

        public Account Account { get; set; }
    }
}
