using System.ComponentModel.DataAnnotations;

namespace AirlinesReservationWebProject2.Entities
{
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }
        public string Name { get; set; }
        public DateTime DeparatureTime { get; set; }

        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
        public List<Seat> Seats { get; set; } = new List<Seat>();
    }
}

