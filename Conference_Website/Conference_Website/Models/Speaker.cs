using System.ComponentModel.DataAnnotations;

namespace Conference_Website.Models
{
    public class Speaker
    {

        [Key]
        public int Id{ get; set; }

        [Required]
        public string NameAndSurname{ get; set; }

        [Required]
        public string Description{ get; set; }

        [Required]
        public string Career { get; set; }


        public string Image { get; set; }

    }
}
