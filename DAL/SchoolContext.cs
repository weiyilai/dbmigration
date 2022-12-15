using dbmigration.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Reflection;
using System.Reflection.Metadata;

namespace dbmigration.DAL;

public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Course> Courses { get; set; }

    public SchoolContext(DbContextOptions<SchoolContext> options)
        : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Student>()
            .ToTable("Student")
            .Property(b => b.ID)
            .IsRequired();

        builder.Entity<Enrollment>()
            .ToTable("Enrollment")
            .Property(b => b.EnrollmentID)
            .IsRequired();

        builder.Entity<Course>()
            .ToTable("Course")
            .Property(b => b.CourseID)
            .IsRequired();

        base.OnModelCreating(builder);
    }
}
