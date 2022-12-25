using MediatR;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;

namespace SportClub.Application.CQRS.Coach.Command;

public class AddCoachesToGroupCommandHandler: IRequestHandler<AddCoachesToGroupCommand, SportClub.Domain.Entity.Coach>
{
    private readonly ICoachRepository _repository;

    public AddCoachesToGroupCommandHandler(ICoachRepository repository)
    {
        _repository = repository;
    }

    public async Task<SportClub.Domain.Entity.Coach> Handle(AddCoachesToGroupCommand request, CancellationToken cancellationToken)
    {
        if (request.Coaches == null) return default!;
        foreach (var coachId in request.Coaches)
        {
            var entity = await _repository.GetById(coachId);
            if (entity == null) continue;
            var coachGroup = new CoachGroup
            {
                CoachId = entity.Id,
                GroupId = request.GroupId
            };
            entity.CoachGroups.Add(coachGroup);
            await _repository.Update(entity);
        }

        return default!;
    }
}