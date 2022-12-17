using MediatR;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.CQRS.Exercise.Query;

public class GetExerciseByIdQuery: IRequest<ExerciseListModel>
{
    public Guid Id { get; set; }
}