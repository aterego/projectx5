using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DAL.Models;

namespace userServices.Resources
{
    public class UsersProfiResource
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Required]
        public DateTime BirthDate { get; set; }
        public string PassportId { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Company { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public byte[] Photo { get; set; }
        public string Memo { get; set; }
        public string LicenceId { get; set; }

        public Users User { get; set; }
        public ICollection<Answers> Answers { get; set; }
        public UserCredentialsResource UserCredentials { get; set; }

        public string LastIP { get; set; }
    }
}
