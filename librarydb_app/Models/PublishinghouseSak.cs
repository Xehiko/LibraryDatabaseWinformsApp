using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace librarydb_app.Models
{
    [Table("publishinghouse_sak")]
    public partial class PublishinghouseSak
    {
        public PublishinghouseSak()
        {
            BookSak = new HashSet<BookSak>();
            PublishingSak = new HashSet<PublishingSak>();
        }

        [Key]
        [Column("PublishingHouseID")]
        public int PublishingHouseId { get; set; }
        [Required]
        [StringLength(66)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string HousePhoneNumber { get; set; }
        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [InverseProperty("PublishingHouse")]
        [Browsable(false)]
        public virtual ICollection<BookSak> BookSak { get; set; }
        [InverseProperty("PublishingHouse")]
        [Browsable(false)]
        public virtual ICollection<PublishingSak> PublishingSak { get; set; }
    }
}
