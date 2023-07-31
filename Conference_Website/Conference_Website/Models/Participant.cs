using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.ComponentModel.DataAnnotations;

namespace Conference_Website.Models
{
    public class Participant
    {
       public Participant()
        {
            Verfication = false;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public  string  Surname { get; set; }
        
        [Required]
        public  string  Email { get; set; }

        public  bool  Verfication { get; set; }

        public  int  VerficationCode { get; set; }

        public DateTime RegisterDate { get; set; }
    }
}
