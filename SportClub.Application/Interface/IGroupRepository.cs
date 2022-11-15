using SportClub.Domain.Entity;

namespace SportClub.Application.Interface;

public interface IGroupRepository: IRepository<Group>
{ 
    new Task<IEnumerable<Group>> GetAll();
    public Task<IEnumerable<Group>> GetPageable(int page, int itemsPerPage);
}