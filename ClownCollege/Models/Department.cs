using System.Collections.Generic;

namespace ClownCollege.Models
{
  public class Department
  {
    public Department()
    {
      this.JoinEntities = new HashSet<DepartmentStudent>();
      this.JoinEntities2 = new HashSet<CourseDepartment>();
    }
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<DepartmentStudent> JoinEntities { get; set; }
    public virtual ICollection<CourseDepartment> JoinEntities2 { get; set; }
  }
}