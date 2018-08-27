using System.ComponentModel.DataAnnotations;
namespace MDojoSurvey
{
    //survey class the is pasted throw the controller.
    public class LangSurvey
    {
        [Required]
        [MinLength(2)]
        [MaxLength(15)]
        public string FullName { get; set;}
        [Required]
        public string DojoLocation {get; set;}
        [Required]
        public string Language {get; set;}
        [MinLength(8)]
        [MaxLength(30)]
        public string Comment {get; set;}
    }
}