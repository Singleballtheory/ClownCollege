using System.Collections.Generic;

namespace ClownCollege.Models
{
  public class Course
  {
    public Course()
    {
      this.JoinEntities = new HashSet<CourseStudent>();
      this.JoinEntities2 = new HashSet<CourseDepartment>();
    }

    public int CourseId { get; set; }
    public string Name { get; set; }
    public string CourseNumber { get; set; }
    public virtual ICollection<CourseStudent> JoinEntities { get; set; }
    public virtual ICollection<CourseDepartment> JoinEntities2 { get; }
  }
}