using System.ComponentModel.DataAnnotations;

namespace FormSubmit
{
    public class User
    {
        [Required]
        [MinLength(4, ErrorMessage = "Needs be longer than 4 characters")]
        [Display(Name = "First Name:")]
        public string first_name {get; set;}
        [Required]
        [MinLength(4, ErrorMessage = "Needs be longer than 4 characters")]
        [Display(Name = "Last Name:")]
        public string last_name {get; set;}
        [Required]
        [Range(0, 200)]
        [Display(Name = "Age:")]
        public int age {get; set;}
        [Required]
        [EmailAddress(ErrorMessage = "Not a Valid Email")]
        [Display(Name = "Email:")]
        public string Email {get; set;}
        [Required]
        [MinLength(8, ErrorMessage = "Needs to be 8 characters")]
        [DataType(DataType.Password)]
        [Display(Name ="Password:")]
        public string Password {get; set;}
    }
}