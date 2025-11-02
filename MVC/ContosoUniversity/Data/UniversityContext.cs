using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
	public class UniversityContext:DbContext
	{
		public UniversityContext(DbContextOptions<UniversityContext> options):base(options) { }

		public DbSet<Course> Courses { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<Enrollment> Enrollments { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Course>().ToTable("Courses");
			modelBuilder.Entity<Student>().ToTable("Students");
			modelBuilder.Entity<Enrollment>().ToTable("Enrollments");
		}
	}
}
