using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;

namespace SportClub.Application.CQRS.Competitor.Command;

public class AddCompetitorCommandHandler: IRequestHandler<AddCompetitorCommand, SportClub.Domain.Entity.Competitor>
{
    private readonly IRepository<SportClub.Domain.Entity.Competitor> _repository;
    private readonly IMapper _mapper;
    public AddCompetitorCommandHandler(IRepository<SportClub.Domain.Entity.Competitor> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<SportClub.Domain.Entity.Competitor> Handle(AddCompetitorCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<SportClub.Domain.Entity.Competitor>(request);
        await _repository.Save(entity);
        return default!;
    }
}