using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace librarydb_app.Models
{
    [Table("reader_sak")]
    public partial class ReaderSak
    {
        public ReaderSak()
        {
            BookingSak = new HashSet<BookingSak>();
        }

        [Key]
        [Column("ReaderID")]
        public int ReaderId { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [Required]
        [StringLength(30)]
        public string MiddleName { get; set; }
        public int NumberOfBookLoans { get; set; }
        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }
        [Required]
        [StringLength(255)]
        public string HomeAddress { get; set; }
        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [Key]
        [Column("User_ID")]
        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(UserSak.ReaderSak))]
        [Browsable(false)]
        public virtual UserSak User { get; set; }
        [Browsable(false)]
        public virtual ICollection<BookingSak> BookingSak { get; set; }
    }
}
