using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesCompetitiveProgramation.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
    }
}
