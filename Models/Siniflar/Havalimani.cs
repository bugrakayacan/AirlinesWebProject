using System.ComponentModel.DataAnnotations;

namespace airlinesSys.Models
{
    public class Havalimani
    {
        [Key]
        public string Airportid { get; set; }
        public string Airportname { get; set; }
    }
}
