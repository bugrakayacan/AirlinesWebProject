using System.ComponentModel.DataAnnotations;

namespace airlinesSys.Siniflar.Models
{
    public class Guzergah
    {
        [Key]
        public int GuzergahId { get; set; }

        public string KalkisAirpotId { get; set; }

        public string VarisAirportId { get; set; }
    }
}
