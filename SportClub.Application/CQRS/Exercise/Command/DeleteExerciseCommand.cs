using MediatR;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Exercise.Command;

public class DeleteExerciseCommand: IRequest<Response<string>>
{
    public Guid Id { get; set; } 
}