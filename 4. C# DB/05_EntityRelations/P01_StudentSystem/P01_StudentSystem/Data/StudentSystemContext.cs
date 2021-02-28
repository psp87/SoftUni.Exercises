namespace P01_StudentSystem.Data
{
    using Microsoft.EntityFrameworkCore;
    using P01_StudentSystem.Data.Models;

    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext()
        {
        }

        public StudentSystemContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Resource> Resources { get; set; }

        public DbSet<Homework> Homeworks { get; set; }

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(c => c.CourseId);

                entity
                    .Property(c => c.Name)
                    .HasMaxLength(80)
                    .IsRequired(true)
                    .IsUnicode(true);

                entity
                    .Property(d => d.Description)
                    .IsRequired(false)
                    .IsUnicode(true);

                entity
                    .Property(sd => sd.StartDate)
                    .IsRequired(true)
                    .IsUnicode(false);

                entity
                    .Property(sd => sd.EndDate)
                    .IsRequired(true)
                    .IsUnicode(false);

                entity
                    .Property(p => p.Price)
                    .IsRequired(true)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.HasKey(c => c.ResourceId);

                entity
                    .Property(c => c.Name)
                    .HasMaxLength(50)
                    .IsRequired(true)
                    .IsUnicode(true);

                entity
                    .Property(d => d.Url)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity
                    .Property(sd => sd.ResourceType)
                    .IsRequired(true)
                    .IsUnicode(false);

                entity
                    .HasOne(c => c.Course)
                    .WithMany(r => r.Resources)
                    .HasForeignKey(c => c.CourseId);
            });

            modelBuilder.Entity<Homework>(entity =>
            {
                entity.HasKey(c => c.HomeworkId);

                entity
                    .Property(c => c.Content)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity
                    .Property(d => d.ContentType)
                    .IsRequired(true)
                    .IsUnicode(false);

                entity
                    .Property(sd => sd.SubmissionTime)
                    .IsRequired(true)
                    .IsUnicode(false);

                entity
                    .HasOne(s => s.Student)
                    .WithMany(r => r.HomeworkSubmissions)
                    .HasForeignKey(c => c.StudentId);

                entity
                    .HasOne(c => c.Course)
                    .WithMany(r => r.HomeworkSubmissions)
                    .HasForeignKey(c => c.CourseId);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(c => c.StudentId);

                entity
                    .Property(c => c.Name)
                    .HasMaxLength(100)
                    .IsRequired(true)
                    .IsUnicode(true);

                entity
                    .Property(d => d.PhoneNumber)
                    .HasMaxLength(10) //TO DO IT FIXED
                    .IsRequired(false)
                    .IsUnicode(false);

                entity
                    .Property(sd => sd.RegisteredOn)
                    .IsRequired(true)
                    .IsUnicode(false);

                entity
                    .Property(sd => sd.Birthday)
                    .IsRequired(false)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity.HasKey(sc => new { sc.StudentId, sc.CourseId });

                entity
                    .HasOne(s => s.Student)
                    .WithMany(c => c.CourseEnrollments)
                    .HasForeignKey(s => s.StudentId);

                entity
                    .HasOne(c => c.Course)
                    .WithMany(s => s.StudentsEnrolled)
                    .HasForeignKey(c => c.CourseId);
            });
        }
    }
}
