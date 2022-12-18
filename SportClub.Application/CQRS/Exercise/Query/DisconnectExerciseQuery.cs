using MediatR;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Exercise.Query;

public class DisconnectExerciseQuery: IRequest<Response<string>>
{
    public Guid Id { get; set; }
}