using System.ComponentModel.DataAnnotations;

namespace DojoQuotes.Models
{
    public class Quote
    {
        [Required]
        [MinLength(3)]
        public string Name {get; set;}
        [Required]
        [Display(Name = "Quote")]
        [MinLength(15)]
        public string quote {get;set;}
    }
}