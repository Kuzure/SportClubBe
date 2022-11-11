using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;
using SportClub.Persistance;
using System.Linq.Expressions;

namespace SportClub.Application.Repository
{
    public class CompetitorRepository : Repository<Competitor>, ICompetitorRepository
    {
        public CompetitorRepository(SportClubDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
        public override async Task<IEnumerable<Competitor>> GetAll() =>
           await _dbContext.Competitors.Include(x => x.Group).Include(x=>x.Identity).ToListAsync();

        public async Task<IEnumerable<Competitor>> GetPageable(int page, int itemsPerPage) =>
            await _dbContext.Competitors.Include(x => x.Group).Include(x => x.Identity).OrderBy(x => x.Id)
                .Skip((page - 1) * itemsPerPage).Take(itemsPerPage).ToListAsync();
        public async Task<Competitor?> GetById(Guid Id) => await _dbContext.Competitors.FirstOrDefaultAsync(x => x.Id == Id);
    }
}
