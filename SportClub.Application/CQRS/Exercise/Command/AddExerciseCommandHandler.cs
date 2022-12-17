using AutoMapper;
using MediatR;
using SportClub.Application.Interface;

namespace SportClub.Application.CQRS.Exercise.Command;

public class AddExerciseCommandHandler: IRequestHandler<AddExerciseCommand, SportClub.Domain.Entity.Exercise>
{
    private readonly IRepository<SportClub.Domain.Entity.Exercise> _repository;
    private readonly IMapper _mapper;
    public AddExerciseCommandHandler(IRepository<SportClub.Domain.Entity.Exercise> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<SportClub.Domain.Entity.Exercise> Handle(AddExerciseCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<SportClub.Domain.Entity.Exercise>(request);
        await _repository.Save(entity);
        return default!;
    }
}