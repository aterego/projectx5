using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Questions
    {
        public Questions()
        {
            Answers = new HashSet<Answers>();
            QuestionCategories = new HashSet<QuestionCategories>();
            QuestionPrice = new HashSet<QuestionPrice>();
            Transactions = new HashSet<Transactions>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Text { get; set; }
        public sbyte Active { get; set; }
        public DateTime Created { get; set; }

        public UsersCustomer Customer { get; set; }
        public ICollection<Answers> Answers { get; set; }
        public ICollection<QuestionCategories> QuestionCategories { get; set; }
        public ICollection<QuestionPrice> QuestionPrice { get; set; }
        public ICollection<Transactions> Transactions { get; set; }
    }
}
