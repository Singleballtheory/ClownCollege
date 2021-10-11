using System.Collections.Generic;
using System;

namespace ClownCollege.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities = new HashSet<CourseStudent>();
    }
    public int StudentId { get; set; }
    public string Name { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public virtual ICollection<CourseStudent> JoinEntities { get; }
  }
}