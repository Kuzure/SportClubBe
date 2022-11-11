using SportClub.Domain.Entity;
using System.Linq.Expressions;

namespace SportClub.Application.Interface
{
    public interface ICompetitorRepository : IRepository<Competitor>
    { 
        new Task<IEnumerable<Competitor>> GetAll();
        Task<Competitor?> GetById(Guid Id);
        new Task<IEnumerable<Competitor>> GetPageable(int page, int itemsPerPage);
        new Task<Competitor> Update(Competitor competitor);
    }
}
