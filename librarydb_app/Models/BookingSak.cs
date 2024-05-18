using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace librarydb_app.Models
{
    [Table("booking_sak")]
    public partial class BookingSak
    {
        [Key]
        [Column("BookingID")]
        public int BookingId { get; set; }
        [Column("DepID")]
        public int DepId { get; set; }
        [Column("ReaderID")]
        public int ReaderId { get; set; }
        [Column("BookID")]
        public int BookId { get; set; }
        [Column(TypeName = "date")]
        public DateTime LoanDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime ReturnDate { get; set; }

        [ForeignKey(nameof(BookId))]
        [InverseProperty(nameof(BookSak.BookingSak))]
        [Browsable(false)]
        public virtual BookSak Book { get; set; }
        [ForeignKey(nameof(DepId))]
        [InverseProperty(nameof(BookdepartmentSak.BookingSak))]
        [Browsable(false)]
        public virtual BookdepartmentSak Dep { get; set; }
        public virtual ReaderSak Reader { get; set; }
    }
}
