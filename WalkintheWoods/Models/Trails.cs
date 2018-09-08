using System.ComponentModel.DataAnnotations;

namespace WalkintheWoods.Models
{
    public class Trails
    {
        [Required]
        public string Name {get;set;}
        [DataType(DataType.Text)]
        public string Discription {get;set;}
        public double Miles {get;set;}
        public int Elevation {get; set;}
        [Range(-180, 180)]
        public double Longitude {get; set;}
        [Range(-90, 90)]
        public double latitude {get; set;}

    }
}