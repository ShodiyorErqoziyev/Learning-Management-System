using System.Collections.Generic;

namespace LearningManagementSystem.Entities;

public class Student : Human
{
    public virtual List<Course> Courses { get; set; } = new List<Course>();
}
