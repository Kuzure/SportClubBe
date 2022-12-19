using MediatR;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.CQRS.Exercise.Query;

public class GetExerciseQuery: IRequest<IEnumerable<ExerciseListModel>>
{
    public Guid GroupId { set; get; }
}