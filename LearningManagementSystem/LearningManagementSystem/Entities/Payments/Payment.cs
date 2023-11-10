using LearningManagementSystem.Enums;

namespace LearningManagementSystem.Entities;

public class Payment : Auditable
{
    public long StudentId { get; set; }
    public long CourseId { get; set; }
    public decimal Price { get; set; }
    public PaymentType PaymentType { get; set; }
}
