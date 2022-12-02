using SportClub.Domain.Entity;

namespace SportClub.Infrastructure.Models;

public class CoachListModel
{
    public Guid? Id { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; } = null!;
    public string? Gender { get; set; }
    public string? Degree { get; set; }
    public int CoachClass { get; set; }
    public ICollection<CoachGroupListModel>? CoachGroups { get; set; }
}