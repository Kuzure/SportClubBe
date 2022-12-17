using SportClub.Domain.Entity;

namespace SportClub.Application.Interface;

public interface ICoachGroupsRepository: IRepository<CoachGroup>
{
    Task<CoachGroup?> GetIfExistByGroupId(Guid groupId);
}