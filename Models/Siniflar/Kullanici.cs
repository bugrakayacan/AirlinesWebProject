using System.ComponentModel.DataAnnotations;
using System.Data;

namespace airlinesSys.Models.Siniflar
{
    public class Kullanici
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

    }
}