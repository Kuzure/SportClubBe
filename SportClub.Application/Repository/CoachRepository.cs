using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;
using SportClub.Persistance;

namespace SportClub.Application.Repository;

public class CoachRepository: Repository<Coach>, ICoachRepository
{
    public CoachRepository(SportClubDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
    }
    public override async Task<IEnumerable<Coach>> GetAll() =>
        await _dbContext.Coaches.Include(x => x.CoachGroups).Include(x=>x.Identity).ToListAsync();

    public async Task<IEnumerable<Coach>> GetPageable(int page, int itemsPerPage) =>
        await _dbContext.Coaches.Include(x => x.CoachGroups).ThenInclude(x=>x.Group).Include(x => x.Identity).OrderBy(x => x.Id)
            .Skip((page - 1) * itemsPerPage).Take(itemsPerPage).ToListAsync();

    public Task<IEnumerable<Coach>> GetByGroupId(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<Coach?> GetById(Guid id) => await _dbContext.Coaches.Include(x=>x.CoachGroups).ThenInclude(x=>x.Group).Include(x=>x.Identity).FirstOrDefaultAsync(x => x.Id == id && x.IsActive);
    
}