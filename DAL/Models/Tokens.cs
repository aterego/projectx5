using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Tokens
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public long Expiration { get; set; }

    }
}
