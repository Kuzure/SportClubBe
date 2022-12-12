using MediatR;
using SportClub.Domain.Enum;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.CQRS.Coach.Command;

public class UpdateCoachCommand: IRequest<Domain.Entity.Coach>
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; } = null!;
    public string? Gender { get; set; }
    public int CoachClass { get; set; }
}