using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace airlinesSys.Models.Siniflar
{
    public class Ucus
    {
        [Key]
        public int UcusId { get; set; }
        [Required]
        public string FlayingFrom { get; set; }
        public string ArrivingTo { get; set; }
        public string FlayingTime { get; set; }
        public string ArrivingTime { get; set; }
        public double TicketPrice { get; set; }

        public int PlaneModelId { get; set; }
        public virtual Ucak PlaneModel { get; set; }


    }
}