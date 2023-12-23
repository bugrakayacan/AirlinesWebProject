using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace airlinesSys.Models.Siniflar
{
    public class Ucak
    {
        [Key]
        public int PlaneModelId { get; set; }
        public string PlaneModelName { get; set; }
        [Required]
        public int seatcount { get; set; }

        public virtual ICollection<Ucus> Ucuslar { get; set; }

    }
}
