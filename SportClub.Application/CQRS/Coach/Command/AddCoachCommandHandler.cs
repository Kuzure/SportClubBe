using AutoMapper;
using MediatR;
using SportClub.Application.Interface;

namespace SportClub.Application.CQRS.Coach.Command;

public class AddCoachCommandHandler: IRequestHandler<AddCoachCommand, SportClub.Domain.Entity.Coach>
{
    private readonly ICoachRepository _repository;
    private readonly IMapper _mapper;
    public AddCoachCommandHandler(ICoachRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<SportClub.Domain.Entity.Coach> Handle(AddCoachCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<SportClub.Domain.Entity.Coach>(request);
        await _repository.Save(entity);
        return default!;
    }
}