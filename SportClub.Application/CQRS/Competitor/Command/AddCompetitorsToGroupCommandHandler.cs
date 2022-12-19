using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;

namespace SportClub.Application.CQRS.Competitor.Command;

public class AddCompetitorsToGroupCommandHandler: IRequestHandler<AddCompetitorsToGroupCommand, SportClub.Domain.Entity.Competitor>
{
    private readonly ICompetitorRepository _repository;
    private readonly IMapper _mapper;
    public AddCompetitorsToGroupCommandHandler(ICompetitorRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<SportClub.Domain.Entity.Competitor> Handle(AddCompetitorsToGroupCommand request, CancellationToken cancellationToken)
    {
        foreach (var competitorId in request.Competitors)
        {
            var entity = await _repository.GetById(competitorId);
            if (entity == null) continue;
            entity.GroupId = request.GroupId;
            await _repository.Update(entity);
        }

        return default!;
    }
}