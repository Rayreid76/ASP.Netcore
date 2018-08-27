using System.ComponentModel.DataAnnotations;
namespace Teatapp.Models
{
    public class Survey
    {
        [Required]
        [MinLength(4)]
        [MaxLength(15)]
        public string FullName {get; set;}
        [Required]
        [MinLength(4)]
        [MaxLength(15)]
        public string DojoLocation {get; set;}
        [Required]
        [MinLength(4)]
        [MaxLength(15)]
        public string Language {get; set;}
        [Required]
        [MinLength(8)]
        [MaxLength(30)]
        public string Comment {get; set;}
    }
}