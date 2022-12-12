using AutoMapper;
using MediatR;
using SportClub.Application.CQRS.Coach.Command;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Coach.Query;

public class AddCoachToGroupQueryHandler : IRequestHandler<AddCoachToGroupQuery, Response<string>>
{
    private readonly ICoachRepository _repository;
    private readonly ICoachGroupsRepository _repositoryCoachGroup;
    private readonly IMapper _mapper;

    public AddCoachToGroupQueryHandler(ICoachRepository repository,ICoachGroupsRepository repositoryCoachGroup, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
        _repositoryCoachGroup = repositoryCoachGroup;
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