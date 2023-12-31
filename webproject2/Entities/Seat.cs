using System.ComponentModel.DataAnnotations;

namespace AirlinesReservationWebProject2.Entities
{
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }
        public string SeatNo { get; set; }
        public bool isReserved { get; set; } = false;
        public int FlightId { get; set; }
        public virtual Flight Flight { get; set; }

    }
}
