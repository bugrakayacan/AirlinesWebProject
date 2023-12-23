
using System.ComponentModel.DataAnnotations;

namespace airlinesSys.Models.Siniflar
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<Kullanici> Kullanicilar { get; set; }

    }
}
