using MediatR;
using SportClub.Application.Interface;

namespace SportClub.Application.CQRS.Competitor.Command;

public class AddCompetitorsToGroupCommandHandler: IRequestHandler<AddCompetitorsToGroupCommand, SportClub.Domain.Entity.Competitor>
{
    private readonly ICompetitorRepository _repository;

    public AddCompetitorsToGroupCommandHandler(ICompetitorRepository repository)
    {
        _repository = repository;
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