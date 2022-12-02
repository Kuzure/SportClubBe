namespace SportClub.Infrastructure.Models;

public class CompetitorModel
{
    public Guid? Id { get; set; }
    public string? FirstName { get; set; } 
    public string? LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? PhoneNumber { get; set; } 
    public string? Gender { get; set; }
    public string? Degree { get; set; }
    public bool Is_Paid { get; set; }
    public DateTime MedicalExaminationExpiryDate { get; set; }
}
