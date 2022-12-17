using MediatR;

namespace SportClub.Application.CQRS.Exercise.Command;

public class AddExerciseCommand: IRequest<Domain.Entity.Exercise>
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
}