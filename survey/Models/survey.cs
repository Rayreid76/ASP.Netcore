using System;
using System.ComponentModel.DataAnnotations;

namespace survey.Models
{
    public class langSurvey
    {
        [Required]
        [MinLength(4)]
        public string FullName {get;set;}
        [Required]
        [MinLength(4)]
        public string dojoLocation {get;set;}
        [Required]
        [MinLength(4)]
        public string Language {get;set;}
        [Required]
        [MinLength(8)]
        [MaxLength(30)]
        public string Comment {get;set;}
    }
}