using System.ComponentModel.DataAnnotations;

namespace AirlinesReservationWebProject2.Entities
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int FlightId { get; set; }
        public virtual Flight Flight { get; set; }
        public int SeatId { get; set; }
        public virtual Seat Seat { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

    }
}
