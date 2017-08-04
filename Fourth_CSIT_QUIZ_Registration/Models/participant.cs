using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fourth_CSIT_QUIZ_Registration.Models
{
    public class participant
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Semester { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CollegeName { get; set; }
        public bool CheckedIn { get; set; }
    }
}