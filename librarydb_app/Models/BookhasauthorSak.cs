using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace librarydb_app.Models
{
    [Table("bookhasauthor_sak")]
    public partial class BookhasauthorSak
    {
        [Key]
        [Column("BookID")]
        public int BookId { get; set; }
        [Key]
        [Column("AuthorID")]
        public int AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        [InverseProperty(nameof(AuthorSak.BookhasauthorSak))]
        public virtual AuthorSak Author { get; set; }
        [ForeignKey(nameof(BookId))]
        [InverseProperty(nameof(BookSak.BookhasauthorSak))]
        public virtual BookSak Book { get; set; }
    }
}
