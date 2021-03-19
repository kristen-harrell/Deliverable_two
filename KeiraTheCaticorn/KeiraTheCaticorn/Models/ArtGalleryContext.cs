using Microsoft.EntityFrameworkCore;

#nullable disable

namespace KeiraTheCaticorn.Models
{
    public partial class ArtGalleryContext : DbContext
    {
        public ArtGalleryContext()
        {
        }

        public ArtGalleryContext(DbContextOptions<ArtGalleryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TagCommentRelation> TagCommentRelations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(255);

                entity.Property(e => e.Comment1)
                    .HasMaxLength(1000)
                    .HasColumnName("Comment");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("date")
                    .HasColumnName("Date Added");

                entity.Property(e => e.UserId).HasMaxLength(255);

                entity.Property(e => e.UserImage).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(255);

                entity.Property(e => e.TagName).HasMaxLength(255);
            });

            modelBuilder.Entity<TagCommentRelation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CommentId).HasMaxLength(255);

                entity.Property(e => e.TagId).HasMaxLength(255);

                entity.HasOne(d => d.Comment)
                    .WithMany()
                    .HasForeignKey(d => d.CommentId)
                    .HasConstraintName("FK__TagCommen__Comme__398D8EEE");

                entity.HasOne(d => d.Tag)
                    .WithMany()
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK__TagCommen__TagId__3A81B327");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
