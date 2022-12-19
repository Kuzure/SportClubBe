using SportClub.Domain.Entity;

namespace SportClub.Application.Interface;

public interface ICoachRepository: IRepository<Coach>
{ 
    new Task<IEnumerable<Coach>> GetAll();
    Task<Coach?> GetById(Guid id);
    Task<IEnumerable<Coach>> GetPageable(int page, int itemsPerPage);
    new Task<Coach> Update(Coach competitor);
    Task<IEnumerable<Coach>> GetCoachByGroupId(Guid id);
    Task<IEnumerable<Coach>> GetAllWithNoGroup(Guid groupId);
}