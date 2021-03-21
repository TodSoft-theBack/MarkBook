using Services.Models;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public partial class MarkBookDBContext : DbContext
    {
        public MarkBookDBContext() : base() { }
        public MarkBookDBContext(DbContextOptions<MarkBookDBContext> options) : base(options) { }
        public virtual DbSet<Grades> Grades { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Marks> Marks { get; set; }
        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Server=127.0.0.1; Database=markbook_db; uID=MarkBook; pwd=123456789; persistsecurityinfo=True");
            }
        }
   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Admins>(entity =>
            {
                entity.HasKey(e => e.AdminID);

                entity.ToTable("admins");

                entity.HasIndex(e => e.UserID)
                      .HasName("FK_User_IDs");


                entity.Property(e => e.FirstName)
                      .IsRequired()
                      .HasMaxLength(45);

                entity.Property(e => e.LastName)
                   .IsRequired()
                   .HasMaxLength(45);
            });

            modelBuilder.Entity<Teachers>(entity =>
            {
                entity.HasKey(e => e.TeacherID);

                entity.ToTable("teachers");

                entity.HasIndex(e => e.UserID)
                      .HasName("FK_User_ID");

                entity.Property(e => e.FirstName)
                      .IsRequired()
                      .HasMaxLength(45);

                entity.Property(e => e.LastName)
                   .IsRequired()
                   .HasMaxLength(45);
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.StudentID);

                entity.ToTable("students");

                entity.HasIndex(e => e.UserID)
                      .HasName("FK_User's_ID");

                entity.HasIndex(e => e.GradeID)
                    .HasName("FK_GradeID");

                entity.Property(e => e.FirstName)
                   .IsRequired()
                   .HasMaxLength(45);

                entity.Property(e => e.LastName)
                   .IsRequired()
                   .HasMaxLength(45);
            });

            modelBuilder.Entity<Subjects>(entity =>
            {
                entity.HasKey(e => e.SubjectID);

                entity.ToTable("Subjects");

                entity.Property(e => e.SubjectTitle)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.HasIndex(e => e.TeacherID)
                      .HasName("FK_TeacherId");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserID);

                entity.ToTable("users");

                entity.Property(e => e.Username)
                        .IsRequired()
                        .HasMaxLength(45);

                entity.Property(e => e.Password)
                        .IsRequired()
                        .HasMaxLength(45);
            });

            modelBuilder.Entity<Grades>(entity =>
            {
                entity.HasKey(e => e.GradeID);

                entity.ToTable("grades");

                entity.Property(e => e.GradeNumber)
                      .IsRequired();

                entity.Property(e => e.GradeForm)
                .IsRequired()
                .HasMaxLength(1);
            });

            modelBuilder.Entity<gradessubjects>(entity =>
            {
                entity.HasKey(e => new { e.GradeID, e.subjectID });

                entity.ToTable("gradessubjects");

                entity.HasIndex(e => e.subjectID)
                      .HasName("FK_Grade_ID");
            });

            modelBuilder.Entity<Marks>(entity =>
            {
                entity.HasKey(e => e.MarkID);

                entity.ToTable("Marks");

                entity.HasIndex(e => e.SubjectID)
                      .HasName("FK_SubjectID");

                entity.HasIndex(e => e.StudentID)
                      .HasName("FK_Student_ID");

                entity.Property(e => e.Comment)
                      .IsRequired()
                      .HasMaxLength(150);
            });
        }
    }
}
