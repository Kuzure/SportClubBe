using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Coach.Command;

public class DeleteCoachCommandHandler: IRequestHandler<DeleteCoachCommand, Response<string>>
{
    private readonly IRepository<SportClub.Domain.Entity.Coach> _repository;
    private readonly IMapper _mapper;
    public DeleteCoachCommandHandler(IRepository<SportClub.Domain.Entity.Coach> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<Response<string>> Handle(DeleteCoachCommand request, CancellationToken cancellationToken)
    {
        await _repository.Delete(request.Id);
        return default!;
    }
}