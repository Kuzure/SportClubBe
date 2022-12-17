using MediatR;

namespace SportClub.Application.CQRS.Exercise.Command;

public class UpdateExerciseCommand: IRequest<SportClub.Domain.Entity.Exercise>
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
}