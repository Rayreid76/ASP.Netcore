using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class Users
    {
        

        [Required]
        [MinLength(4)]
        public string FName { get; set; }

        [Required]
        [MinLength(4)]
        public string LName { get; set; }

        [Required]
        [EmailAddress]
        public string UserEmail { get; set; }

        [Required]
        [Range(0, 175)]
        public int UserAge { get; set; }

        [Required]
        [MinLength(8)]
        public string UserPassword { get; set; }
    }
}