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
    [Table("book_sak")]
    public partial class BookSak
    {
        public BookSak()
        {
            BookhasauthorSak = new HashSet<BookhasauthorSak>();
            BookingSak = new HashSet<BookingSak>();
        }

        [Key]
        [Column("BookID")]
        public int BookId { get; set; }
        [Column("BookDepartmentID")]
        public int BookDepartmentId { get; set; }
        [Column("PublishingHouseID")]
        public int PublishingHouseId { get; set; }
        [Required]
        [StringLength(66)]
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime ReceiptDate { get; set; }
        public int InventoryNumber { get; set; }

        [ForeignKey(nameof(BookDepartmentId))]
        [InverseProperty(nameof(BookdepartmentSak.BookSak))]
        [Browsable(false)]
        public virtual BookdepartmentSak BookDepartment { get; set; }
        [ForeignKey(nameof(PublishingHouseId))]
        [InverseProperty(nameof(PublishinghouseSak.BookSak))]
        [Browsable(false)]
        public virtual PublishinghouseSak PublishingHouse { get; set; }
        [InverseProperty("Book")]
        [Browsable(false)]
        public virtual ICollection<BookhasauthorSak> BookhasauthorSak { get; set; }
        [InverseProperty("Book")]
        [Browsable(false)]
        public virtual ICollection<BookingSak> BookingSak { get; set; }
    }
}
