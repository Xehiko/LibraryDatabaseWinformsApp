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
    [Table("author_sak")]
    public partial class AuthorSak
    {
        public AuthorSak()
        {
            BookhasauthorSak = new HashSet<BookhasauthorSak>();
            PublishingSak = new HashSet<PublishingSak>();
        }

        [Key]
        [Column("AuthorID")]
        public int AuthorId { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string MiddleName { get; set; }
        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DeathDate { get; set; }
        [StringLength(1200)]
        public string AuthorBriefBiography { get; set; }

        [InverseProperty("Author")]
        [Browsable(false)]
        public virtual ICollection<BookhasauthorSak> BookhasauthorSak { get; set; }
        [InverseProperty("Author")]
        [Browsable(false)]
        public virtual ICollection<PublishingSak> PublishingSak { get; set; }
    }
}
