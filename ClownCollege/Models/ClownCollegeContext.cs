using Microsoft.EntityFrameworkCore;

namespace ClownCollege.Models
{
  public class ClownCollegeContext : DbContext
  {
    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<CourseStudent> CourseStudent { get; set; }
    public DbSet<DepartmentStudent> DepartmentStudent { get; set; }
    public DbSet<CourseDepartment> CourseDepartment { get; set; }

    public ClownCollegeContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}