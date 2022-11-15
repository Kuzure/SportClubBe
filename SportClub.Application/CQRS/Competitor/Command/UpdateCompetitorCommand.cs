using MediatR;

namespace SportClub.Application.CQRS.Competitor.Command;

public class UpdateCompetitorCommand: IRequest<SportClub.Domain.Entity.Competitor>
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }= null!;
    public string Gender { get; set; }= null!;
    public string? Degree { get; set; }
    public bool Is_Paid { get; set; }
    public DateTime MedicalExaminationExpiryDate { get; set; }
    public Guid? GroupId { get; set; }
}