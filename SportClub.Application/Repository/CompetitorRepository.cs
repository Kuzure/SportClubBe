using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;
using SportClub.Persistance;
using System.Linq.Expressions;
using SportClub.Infrastructure.Models;

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
        public async Task<Competitor?> GetById(Guid id) => await _dbContext.Competitors.Include(x=>x.Group).Include(x=>x.Identity).FirstOrDefaultAsync(x => x.Id == id && x.IsActive);

        public async Task<IEnumerable<Competitor>> GetByGroupId(Guid id) =>
            await _dbContext.Competitors.Include(x => x.Group).Include(x => x.Identity)
                .Where(x => x.GroupId == id && x.IsActive).ToListAsync();

        public async Task<IEnumerable<Competitor>> GetAllWithNoGroup() =>
            await _dbContext.Competitors.Include(x => x.Group).Include(x => x.Identity).Where(x => x.GroupId == null).ToListAsync();

    }
}
