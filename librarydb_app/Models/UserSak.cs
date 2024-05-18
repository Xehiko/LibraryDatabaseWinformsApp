using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace librarydb_app.Models
{
    [Table("user_sak")]
    public partial class UserSak
    {
        public UserSak()
        {
            ReaderSak = new HashSet<ReaderSak>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Login { get; set; }
        [Required]
        [StringLength(25)]
        public string Password { get; set; }
        [Required]
        [StringLength(15)]
        public string Role { get; set; }

        [InverseProperty("User")]
        [Browsable(false)]
        public virtual ICollection<ReaderSak> ReaderSak { get; set; }
    }
}
