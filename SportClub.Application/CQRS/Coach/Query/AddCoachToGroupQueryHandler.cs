using MediatR;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Coach.Query;

public class AddCoachToGroupQueryHandler : IRequestHandler<AddCoachToGroupQuery, Response<string>>
{
    private readonly ICoachRepository _repository;

    public AddCoachToGroupQueryHandler(ICoachRepository repository)
    {
        _repository = repository;
    }
    public async Task<Response<string>> Handle(AddCoachToGroupQuery query, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetById(query.Id);
        if (entity == null)
            return default!;
        var coachGroups = new List<CoachGroup>();
        if (query.GroupListId != null)
            foreach (var guid in query.GroupListId)
            {
                var coachGroup = new CoachGroup();
                coachGroup.CoachId = query.Id;
                coachGroup.GroupId = guid;
                coachGroups.Add(coachGroup);
            }

        entity.CoachGroups = coachGroups;
        await _repository.Update(entity);
        return default!;
    }
}