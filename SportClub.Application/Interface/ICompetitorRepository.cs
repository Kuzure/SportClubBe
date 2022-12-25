using SportClub.Domain.Entity;

namespace SportClub.Application.Interface
{
    public interface ICompetitorRepository : IRepository<Competitor>
    { 
        new Task<IEnumerable<Competitor>> GetAll();
        Task<Competitor?> GetById(Guid id);
        Task<IEnumerable<Competitor>> GetPageable(int page, int itemsPerPage);
        new Task<Competitor> Update(Competitor competitor);
        Task<IEnumerable<Competitor>> GetByGroupId(Guid id);
         Task<IEnumerable<Competitor>> GetAllWithNoGroup();
    }
}
