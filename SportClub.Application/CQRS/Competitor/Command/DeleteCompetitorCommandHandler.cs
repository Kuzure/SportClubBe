using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Competitor.Command;

public class DeleteCompetitorCommandHandler: IRequestHandler<DeleteCompetitorCommand, Response<string>>
{
    private readonly IRepository<SportClub.Domain.Entity.Competitor> _repository;
    private readonly IMapper _mapper;
    public DeleteCompetitorCommandHandler(IRepository<SportClub.Domain.Entity.Competitor> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<Response<string>> Handle(DeleteCompetitorCommand request, CancellationToken cancellationToken)
    {
        await _repository.Delete(request.Id);
        return default!;
    }
}