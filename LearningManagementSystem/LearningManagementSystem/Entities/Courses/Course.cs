namespace LearningManagementSystem.Entities;

public class Course : Auditable
{
    public long SubjectId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
