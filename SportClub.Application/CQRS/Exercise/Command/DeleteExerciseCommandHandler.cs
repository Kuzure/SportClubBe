using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Exercise.Command;

public class DeleteExerciseCommandHandler: IRequestHandler<DeleteExerciseCommand, Response<string>>
{
    private readonly IRepository<SportClub.Domain.Entity.Exercise> _repository;

    public DeleteExerciseCommandHandler(IRepository<SportClub.Domain.Entity.Exercise> repository)
    {
        _repository = repository;
    }

    public async Task<Response<string>> Handle(DeleteExerciseCommand request, CancellationToken cancellationToken)
    {
        await _repository.Delete(request.Id);
        return default!;
    }
}