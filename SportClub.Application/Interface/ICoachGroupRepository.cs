using SportClub.Domain.Entity;

namespace SportClub.Application.Interface;

public interface ICoachGroupsRepository: IRepository<CoachGroup>
{
    Task<CoachGroup?> GetIfExistByGroupId(Guid groupId);
    new Task<IEnumerable<CoachGroup>> GetAll();
    Task<CoachGroup?> GetById(Guid id);
    Task<IEnumerable<CoachGroup>> GetPageable(int page, int itemsPerPage);
    new Task<CoachGroup> Update(CoachGroup coach);
    Task<IEnumerable<CoachGroup>> GetByGroupId(Guid id);
}