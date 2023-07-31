using System;
using System.ComponentModel.DataAnnotations;

namespace Conference_Website.Models
{
    public class Agenda
    {
        [Key]
        public int Id { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Description{ get; set; }
    }
}
