using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Musicapp_backend.Models
{
    public partial class musicappDBContext : DbContext
    {
        public musicappDBContext()
        {
        }

        public musicappDBContext(DbContextOptions<musicappDBContext> options)
            : base(options)
        {
        }

        public  DbSet<Category> Categories { get; set; }
        public  DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
               // optionsBuilder.UseSqlServer("Server=DESKTOP-AAC3EBK; Database=musicappDB; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category_name");
            });

            modelBuilder.Entity<Song>(entity =>
            {
                entity.ToTable("song");

                entity.Property(e => e.SongId).HasColumnName("song_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EditedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("edited_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsFavourite)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("is_favourite");

                entity.Property(e => e.SongArtist)
                    .HasMaxLength(50)
                    .HasColumnName("song_artist");

                entity.Property(e => e.SongName)
                    .HasMaxLength(50)
                    .HasColumnName("song_name");

                entity.Property(e => e.SongRating).HasColumnName("song_rating");

                entity.Property(e => e.SongUrl)
                    .HasMaxLength(255)
                    .HasColumnName("song_url"); 

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("fk_song_category");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
