using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace librarydb_app.Models
{
    [Table("bookdepartment_sak")]
    public partial class BookdepartmentSak
    {
        public BookdepartmentSak()
        {
            BookSak = new HashSet<BookSak>();
            BookingSak = new HashSet<BookingSak>();
        }

        [Key]
        [Column("DepID")]
        public int DepId { get; set; }
        [Required]
        [StringLength(66)]
        public string DepName { get; set; }
        [Required]
        [StringLength(20)]
        public string DepPhoneNumber { get; set; }

        [InverseProperty("BookDepartment")]
        [Browsable(false)]
        public virtual ICollection<BookSak> BookSak { get; set; }
        [InverseProperty("Dep")]
        [Browsable(false)]
        public virtual ICollection<BookingSak> BookingSak { get; set; }
    }
}
