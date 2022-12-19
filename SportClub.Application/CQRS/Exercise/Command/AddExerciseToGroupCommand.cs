using MediatR;

namespace SportClub.Application.CQRS.Exercise.Command;

public class AddExerciseToGroupCommand: IRequest<Domain.Entity.Exercise>
{
    public Guid GroupId { set; get; }
    public IEnumerable<Guid> Exercises { get; set; }
}