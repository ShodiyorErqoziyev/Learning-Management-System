namespace LearningManagementSystem.Entities;

public class Group : Auditable
{
    public long TeacherId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int MaxCapacity { get; set; }
    public int MinCapacity { get; set; }
    public int StudentCount { get; set; }
}
