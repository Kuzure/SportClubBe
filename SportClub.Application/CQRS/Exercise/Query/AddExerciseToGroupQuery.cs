using MediatR;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Exercise.Query;

public class AddExerciseToGroupQuery: IRequest<Response<string>>
{
    public Guid Id { get; set; }
    public IEnumerable<Guid>? GroupListId { get; set; }
}