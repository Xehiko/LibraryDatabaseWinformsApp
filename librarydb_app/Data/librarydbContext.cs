using librarydb_app.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace librarydb_app.Data
{
    public partial class librarydbContext : DbContext
    {
        public librarydbContext()
        {
        }

        public librarydbContext(DbContextOptions<librarydbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuthorSak> AuthorSak { get; set; }
        public virtual DbSet<BookSak> BookSak { get; set; }
        public virtual DbSet<BookdepartmentSak> BookdepartmentSak { get; set; }
        public virtual DbSet<BookhasauthorSak> BookhasauthorSak { get; set; }
        public virtual DbSet<BookingSak> BookingSak { get; set; }
        public virtual DbSet<PublishingSak> PublishingSak { get; set; }
        public virtual DbSet<PublishinghouseSak> PublishinghouseSak { get; set; }
        public virtual DbSet<ReaderSak> ReaderSak { get; set; }
        public virtual DbSet<UserSak> UserSak { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(ConfigurationManager.ConnectionStrings["libraryDB"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorSak>(entity =>
            {
                entity.HasKey(e => e.AuthorId)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("AuthorID_UNIQUE")
                    .IsUnique();
            });

            modelBuilder.Entity<BookSak>(entity =>
            {
                entity.HasKey(e => e.BookId)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.BookDepartmentId)
                    .HasName("fk_Book_SAK_BookDepartment_SAK1_idx");

                entity.HasIndex(e => e.BookId)
                    .HasName("BookID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.PublishingHouseId)
                    .HasName("fk_Book_SAK_PublishingHouse_SAK1_idx");

                entity.HasOne(d => d.BookDepartment)
                    .WithMany(p => p.BookSak)
                    .HasForeignKey(d => d.BookDepartmentId)
                    .HasConstraintName("fk_Book_SAK_BookDepartment_SAK1");

                entity.HasOne(d => d.PublishingHouse)
                    .WithMany(p => p.BookSak)
                    .HasForeignKey(d => d.PublishingHouseId)
                    .HasConstraintName("fk_Book_SAK_PublishingHouse_SAK1");
            });

            modelBuilder.Entity<BookdepartmentSak>(entity =>
            {
                entity.HasKey(e => e.DepId)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.DepId)
                    .HasName("DepID_UNIQUE")
                    .IsUnique();
            });

            modelBuilder.Entity<BookhasauthorSak>(entity =>
            {
                entity.HasKey(e => new { e.BookId, e.AuthorId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("fk_Book_SAK_has_Author_SAK_Author_SAK1_idx");

                entity.HasIndex(e => e.BookId)
                    .HasName("fk_Book_SAK_has_Author_SAK_Book_SAK1_idx");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.BookhasauthorSak)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("fk_Book_SAK_has_Author_SAK_Author_SAK1");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookhasauthorSak)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("fk_Book_SAK_has_Author_SAK_Book_SAK1");
            });

            modelBuilder.Entity<BookingSak>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.BookId)
                    .HasName("BookID_idx");

                entity.HasIndex(e => e.BookingId)
                    .HasName("BookingID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.DepId)
                    .HasName("DepID_idx");

                entity.HasIndex(e => e.ReaderId)
                    .HasName("ReaderID_idx");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookingSak)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("BookID");

                entity.HasOne(d => d.Dep)
                    .WithMany(p => p.BookingSak)
                    .HasForeignKey(d => d.DepId)
                    .HasConstraintName("DepID");

                entity.HasOne(d => d.Reader)
                    .WithMany(p => p.BookingSak)
                    .HasPrincipalKey(p => p.ReaderId)
                    .HasForeignKey(d => d.ReaderId)
                    .HasConstraintName("ReaderID");
            });

            modelBuilder.Entity<PublishingSak>(entity =>
            {
                entity.HasKey(e => new { e.PublishingHouseId, e.AuthorId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("fk_PublishingHouse_SAK_has_Author_SAK_Author_SAK1_idx");

                entity.HasIndex(e => e.PublishingHouseId)
                    .HasName("fk_PublishingHouse_SAK_has_Author_SAK_PublishingHouse_SAK_idx");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.PublishingSak)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("fk_PublishingHouse_SAK_has_Author_SAK_Author_SAK1");

                entity.HasOne(d => d.PublishingHouse)
                    .WithMany(p => p.PublishingSak)
                    .HasForeignKey(d => d.PublishingHouseId)
                    .HasConstraintName("fk_PublishingHouse_SAK_has_Author_SAK_PublishingHouse_SAK");
            });

            modelBuilder.Entity<PublishinghouseSak>(entity =>
            {
                entity.HasKey(e => e.PublishingHouseId)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.PublishingHouseId)
                    .HasName("PublisherHouseID_UNIQUE")
                    .IsUnique();
            });

            modelBuilder.Entity<ReaderSak>(entity =>
            {
                entity.HasKey(e => new { e.ReaderId, e.UserId })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ReaderId)
                    .HasName("ReaderID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("fk_Reader_SAK_User1_idx");

                entity.Property(e => e.ReaderId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReaderSak)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Reader_SAK_User1");
            });

            modelBuilder.Entity<UserSak>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("ID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Login)
                    .HasName("Login_UNIQUE")
                    .IsUnique();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
