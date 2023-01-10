namespace SportClub.Infrastructure.Models;

public class CompetitorDetail
{
    public CompetitorData CompetitorData { get; set; }
    public IdentityData IdentityData { get; set; }
    public GroupData? GroupData { get; set; }
}

public class CompetitorData
{
    public Guid? Id { get; set; } = null!;
    public bool IsPaid { get; set; }
    public DateTime? MedicalExaminationExpiryDate { get; set; }
}

public class IdentityData
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; } = null!;
    public string? Gender { get; set; }
    public string? Degree { get; set; }
}

public class GroupData
{
    public string? GroupName { get; set; }

    public Guid? GroupId { get; set; }
}