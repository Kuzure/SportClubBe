using MediatR;
using SportClub.Domain.Enum;

namespace SportClub.Application.CQRS.Coach.Command;

public class AddCoachCommand: IRequest<Domain.Entity.Coach>
{
    public int CoachClass { get; set; }
    public string? FirstName { get; set; } 
    public string? LastName { get; set; } 
    public DateTime DateOfBirth { get; set; }
    public string? PhoneNumber { get; set; } 
    public Gender Gender { get; set; }
    public Degree? Degree { get; set; }
}