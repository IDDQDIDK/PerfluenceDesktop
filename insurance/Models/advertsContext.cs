using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace insurance.Models
{
    public partial class advertsContext : DbContext
    {
        public advertsContext()
        {
        }

        public advertsContext(DbContextOptions<advertsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Advertisers> Advertisers { get; set; }
        public virtual DbSet<Bloggers> Bloggers { get; set; }
        public virtual DbSet<Kinds> Kinds { get; set; }
        public virtual DbSet<Materials> Materials { get; set; }
        public virtual DbSet<Payouts> Payouts { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Projectkinds> Projectkinds { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<Projecttags> Projecttags { get; set; }
        public virtual DbSet<Requests> Requests { get; set; }
        public virtual DbSet<Scouts> Scouts { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=sql7.freesqldatabase.com; port = 3306;user=sql7624617;pwd=DGsSj9pd2S;database=sql7624617; AllowZeroDateTime=True; convert zero datetime=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Advertisers>(entity =>
            {
                entity.ToTable("advertisers");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Passcode)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Bloggers>(entity =>
            {
                entity.ToTable("bloggers");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Blog)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Passcode)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Patronymic)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Requisits)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SecondName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Kinds>(entity =>
            {
                entity.ToTable("kinds");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Materials>(entity =>
            {
                entity.ToTable("materials");

                entity.HasIndex(e => e.Project)
                    .HasName("Project");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SomeText)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.ProjectNavigation)
                    .WithMany(p => p.Materials)
                    .HasForeignKey(d => d.Project)
                    .HasConstraintName("materials_ibfk_1");
            });

            modelBuilder.Entity<Payouts>(entity =>
            {
                entity.ToTable("payouts");

                entity.HasIndex(e => e.Post)
                    .HasName("Post");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.WhenDate).HasColumnType("date");

                entity.HasOne(d => d.PostNavigation)
                    .WithMany(p => p.Payouts)
                    .HasForeignKey(d => d.Post)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("payouts_ibfk_1");
            });

            modelBuilder.Entity<Posts>(entity =>
            {
                entity.ToTable("posts");

                entity.HasIndex(e => e.Blogger)
                    .HasName("Blogger");

                entity.HasIndex(e => e.Project)
                    .HasName("Project");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Link)
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.WhenDate).HasColumnType("date");

                entity.HasOne(d => d.BloggerNavigation)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.Blogger)
                    .HasConstraintName("posts_ibfk_1");

                entity.HasOne(d => d.ProjectNavigation)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.Project)
                    .HasConstraintName("posts_ibfk_2");
            });

            modelBuilder.Entity<Projectkinds>(entity =>
            {
                entity.ToTable("projectkinds");

                entity.HasIndex(e => e.Kind)
                    .HasName("Kind");

                entity.HasIndex(e => e.Project)
                    .HasName("Project");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.KindNavigation)
                    .WithMany(p => p.Projectkinds)
                    .HasForeignKey(d => d.Kind)
                    .HasConstraintName("projectkinds_ibfk_2");

                entity.HasOne(d => d.ProjectNavigation)
                    .WithMany(p => p.Projectkinds)
                    .HasForeignKey(d => d.Project)
                    .HasConstraintName("projectkinds_ibfk_1");
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.ToTable("projects");

                entity.HasIndex(e => e.Company)
                    .HasName("Company");

                entity.HasIndex(e => e.Responsible)
                    .HasName("Responsible");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateStart).HasColumnType("date");

                entity.Property(e => e.Specification)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.Company)
                    .HasConstraintName("projects_ibfk_2");

                entity.HasOne(d => d.ResponsibleNavigation)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.Responsible)
                    .HasConstraintName("projects_ibfk_1");
            });

            modelBuilder.Entity<Projecttags>(entity =>
            {
                entity.ToTable("projecttags");

                entity.HasIndex(e => e.Project)
                    .HasName("Project");

                entity.HasIndex(e => e.Tag)
                    .HasName("Tag");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.ProjectNavigation)
                    .WithMany(p => p.Projecttags)
                    .HasForeignKey(d => d.Project)
                    .HasConstraintName("projecttags_ibfk_1");

                entity.HasOne(d => d.TagNavigation)
                    .WithMany(p => p.Projecttags)
                    .HasForeignKey(d => d.Tag)
                    .HasConstraintName("projecttags_ibfk_2");
            });

            modelBuilder.Entity<Requests>(entity =>
            {
                entity.ToTable("requests");

                entity.HasIndex(e => e.Blogger)
                    .HasName("Blogger");

                entity.HasIndex(e => e.Project)
                    .HasName("Project");

                entity.HasIndex(e => e.Project)
                    .HasName("Status");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.WhenDate).HasColumnType("date");

                entity.HasOne(d => d.BloggerNavigation)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.Blogger)
                    .HasConstraintName("requests_ibfk_1");

                entity.HasOne(d => d.ProjectNavigation)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.Project)
                    .HasConstraintName("requests_ibfk_2");
            });

            modelBuilder.Entity<Scouts>(entity =>
            {
                entity.ToTable("scouts");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Passcode)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Patronymic)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SecondName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Tags>(entity =>
            {
                entity.ToTable("tags");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
