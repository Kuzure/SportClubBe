using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Exercise.Command;

public class DeleteExerciseCommandHandler: IRequestHandler<DeleteExerciseCommand, Response<string>>
{
    private readonly IRepository<SportClub.Domain.Entity.Exercise> _repository;
    private readonly IMapper _mapper;
    public DeleteExerciseCommandHandler(IRepository<SportClub.Domain.Entity.Exercise> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<Response<string>> Handle(DeleteExerciseCommand request, CancellationToken cancellationToken)
    {
        await _repository.Delete(request.Id);
        return default!;
    }
}