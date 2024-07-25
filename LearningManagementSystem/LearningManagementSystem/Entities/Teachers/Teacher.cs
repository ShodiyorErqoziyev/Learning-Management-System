using System.Collections.Generic;

namespace LearningManagementSystem.Entities;

public class Teacher : Human
{
    public decimal Salary { get; set; }
    public string Status { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Specialty { get; set; } = string.Empty;
    public virtual List<Course> Courses { get; set; } = new List<Course>();
}
