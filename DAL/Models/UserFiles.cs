using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserFiles
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public byte[] File { get; set; }
        public sbyte Active { get; set; }
        public DateTime Created { get; set; }

        public Users User { get; set; }
    }
}
