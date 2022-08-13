using SportClubBe.Entity;
using System.Linq.Expressions;

namespace SportClub.Api.Interface
{
    public interface ICompetitorRepository : IRepository<Competitor>
    { 
        new Task<IEnumerable<Competitor>> GetAll();
    }
}
