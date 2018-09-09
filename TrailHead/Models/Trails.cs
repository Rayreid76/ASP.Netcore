using System;
using System.ComponentModel.DataAnnotations;

namespace TrailHead.Models
{
    public class Trail{
        [Required]
        [MinLength(4, ErrorMessage = "Minimum lenght has not been met")]
        public string Name {get; set;}
        [DataType(DataType.Text)]
        [MinLength(10, ErrorMessage = "Minimum lenght has not been met")]
        public string Describtion {get; set;}
        [Required]
        [Range(0, Int16.MaxValue)]
        public double Miles {get; set;}
        [Required]
        [Range(-282, Int16.MaxValue)]
        public int Elevation {get; set;}
        [Required]
        [Range(-180, 180, ErrorMessage = "Out of range -180 to 180")]
        public double Longitude {get; set;}
        [Required]
        [Range(-90, 90, ErrorMessage = "Out of range -90 to 90")]
        public double Latitude {get; set;}
    }
}