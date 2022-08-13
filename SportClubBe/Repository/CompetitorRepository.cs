using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SportClub.Api.Interface;
using SportClubBe.Entity;
using System.Linq.Expressions;

namespace SportClub.Api.Repository
{
    public class CompetitorRepository : Repository<Competitor>, ICompetitorRepository
    {
        public CompetitorRepository(SportClubDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
        public override async Task<IEnumerable<Competitor>> GetAll() =>
           await _dbContext.Competitors.Include(x => x.Group).Include(x=>x.Identity).ToListAsync();
    }
}
