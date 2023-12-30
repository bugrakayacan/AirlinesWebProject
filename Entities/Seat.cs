using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webprojectplanebooking.Entities
{
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }
        public string SeatNo { get; set; }
        bool IsReserved { get; set; }
        public int FlightId { get; set; }
        public virtual Flight Flight { get; set; }
        
    }
}
