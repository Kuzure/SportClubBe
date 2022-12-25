using MediatR;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Coach.Query;

public class DisconnectCoachQueryHandler: IRequestHandler<DisconnectCoachQuery,Response<string>>
{
    private readonly ICoachRepository _repository;

    public DisconnectCoachQueryHandler(ICoachRepository repository)
    {
        _repository = repository;
    }

    public async Task<Response<string>> Handle(DisconnectCoachQuery query, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetById(query.Id);
        if (entity == null)
            return default!;
        var groups = new List<CoachGroup>();
        foreach (var group in entity.CoachGroups)
        {
            if (group.CoachId == query.Id)
            {
                group.GroupId = null;
            }

            groups.Add(group);
            
        }

        entity.CoachGroups = groups;
        await _repository.Update(entity);
        return default!;
    }
}