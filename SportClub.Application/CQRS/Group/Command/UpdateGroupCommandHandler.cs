using MediatR;
using SportClub.Application.Interface;
using SportClub.Persistance;

namespace SportClub.Application.CQRS.Group.Command;

public class UpdateGroupCommandHandler: IRequestHandler<UpdateGroupCommand, SportClub.Domain.Entity.Group>
{
    private readonly SportClubDbContext _dbContext;
    private readonly IGroupRepository _groupRepository;
    public UpdateGroupCommandHandler(IGroupRepository groupRepository,SportClubDbContext dbContext)
    {
        _groupRepository = groupRepository;
        _dbContext = dbContext;
    }

    public async Task<SportClub.Domain.Entity.Group> Handle(UpdateGroupCommand request, CancellationToken cancellationToken)
    {

        var group = await _groupRepository.GetById(request.Id);
        if (group == null) return default!;
        group.Name = request.Name;
        _dbContext.Update(group);
        await _dbContext.SaveChangesAsync();
        return default!;
    }
}