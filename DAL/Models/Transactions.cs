using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Transactions
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int TransType { get; set; }
        public int TransSystem { get; set; }
        public int QId { get; set; }
        public int AId { get; set; }
        public float Amount { get; set; }
        public string Memo { get; set; }
        public DateTime Created { get; set; }

        public Answers A { get; set; }
        public Account Account { get; set; }
        public Questions Q { get; set; }
        public RefTransSystems TransSystemNavigation { get; set; }
        public RefTransType TransTypeNavigation { get; set; }
    }
}
