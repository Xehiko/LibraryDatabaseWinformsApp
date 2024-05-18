using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace librarydb_app.Models
{
    [Table("publishing_sak")]
    public partial class PublishingSak
    {
        [Key]
        [Column("PublishingHouseID")]
        public int PublishingHouseId { get; set; }
        [Key]
        [Column("AuthorID")]
        public int AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        [InverseProperty(nameof(AuthorSak.PublishingSak))]
        [Browsable(false)]
        public virtual AuthorSak Author { get; set; }
        [ForeignKey(nameof(PublishingHouseId))]
        [InverseProperty(nameof(PublishinghouseSak.PublishingSak))]
        [Browsable(false)]
        public virtual PublishinghouseSak PublishingHouse { get; set; }
    }
}
