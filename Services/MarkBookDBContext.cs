using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Services.Models;

namespace Services
{
    public partial class MarkBookDBContext : DbContext
    {
        public MarkBookDBContext()
        {
        }

        public MarkBookDBContext(DbContextOptions<MarkBookDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Grades> Grades { get; set; }
        public virtual DbSet<Marks> Marks { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Users> Users { get; set; }

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
                entity.HasKey(e => e.AdminId)
                    .HasName("PRIMARY");

                entity.ToTable("admins");

                entity.HasIndex(e => e.AdminId)
                    .HasName("AdminID")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("UserID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Admins)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("admins_ibfk_1");
            });

            modelBuilder.Entity<Grades>(entity =>
            {
                entity.HasKey(e => e.GradeId)
                    .HasName("PRIMARY");

                entity.ToTable("grades");

                entity.HasIndex(e => e.GradeId)
                    .HasName("GradeID")
                    .IsUnique();

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.GradeForm)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Marks>(entity =>
            {
                entity.HasKey(e => e.MarkId)
                    .HasName("PRIMARY");

                entity.ToTable("marks");

                entity.HasIndex(e => e.MarkId)
                    .HasName("MarkID")
                    .IsUnique();

                entity.HasIndex(e => e.StudentId)
                    .HasName("StudentID");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("SubjectID");

                entity.Property(e => e.MarkId).HasColumnName("MarkID");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.MarkValue).HasColumnType("decimal(19,2)");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("marks_ibfk_1");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("marks_ibfk_2");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.StudentId)
                    .HasName("PRIMARY");

                entity.ToTable("students");

                entity.HasIndex(e => e.UserId)
                    .HasName("UserID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("students_ibfk_1");
            });

            modelBuilder.Entity<Subjects>(entity =>
            {
                entity.HasKey(e => e.SubjectId)
                    .HasName("PRIMARY");

                entity.ToTable("subjects");

                entity.HasIndex(e => e.GradeId)
                    .HasName("GradeID");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("SubjectID")
                    .IsUnique();

                entity.HasIndex(e => e.TeacherId)
                    .HasName("TeacherID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.SubjectTitle)
                    .IsRequired()
                    .HasColumnName("SubjectTItle")
                    .HasMaxLength(45);

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("subjects_ibfk_2");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("subjects_ibfk_1");
            });

            modelBuilder.Entity<Teachers>(entity =>
            {
                entity.HasKey(e => e.TeacherId)
                    .HasName("PRIMARY");

                entity.ToTable("teachers");

                entity.HasIndex(e => e.TeacherId)
                    .HasName("TeacherID")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("UserID")
                    .IsUnique();

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Teachers)
                    .HasForeignKey<Teachers>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("teachers_ibfk_1");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("users");

                entity.HasIndex(e => e.UserId)
                    .HasName("UserID")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
