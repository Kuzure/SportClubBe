using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;

namespace SportClub.Application.CQRS.Coach.Command;

public class AddCoachesToGroupCommandHandler: IRequestHandler<AddCoachesToGroupCommand, SportClub.Domain.Entity.Coach>
{
    private readonly ICoachRepository _repository;
    private readonly IMapper _mapper;
    public AddCoachesToGroupCommandHandler(ICoachRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<SportClub.Domain.Entity.Coach> Handle(AddCoachesToGroupCommand request, CancellationToken cancellationToken)
    {
        foreach (var coachId in request.Coaches)
        {
            var entity =await _repository.GetById(coachId);
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