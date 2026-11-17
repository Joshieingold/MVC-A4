using A4_EF_CRUD_Validation.Models;
using Microsoft.EntityFrameworkCore;

namespace DbDemo.Models
{
    public class CourseDbContext : DbContext
    {
        public CourseDbContext(DbContextOptions<CourseDbContext> options)
            : base(options) { }

        public DbSet<Course> Course => Set<Course>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
        }
    }
}
