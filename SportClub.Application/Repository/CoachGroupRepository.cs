using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;
using SportClub.Persistance;

namespace SportClub.Application.Repository;

public class CoachGroupRepository: Repository<CoachGroup>, ICoachGroupsRepository
{
    public CoachGroupRepository(SportClubDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
    }
    
    public Task<CoachGroup?> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CoachGroup>> GetPageable(int page, int itemsPerPage)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CoachGroup>> GetByGroupId(Guid id)
    {
        throw new NotImplementedException();
    }
    public async Task<CoachGroup?> GetIfExistByGroupId(Guid groupId) => await _dbContext.CoacheGroups.Include(x=>x.Group).FirstOrDefaultAsync(x => x.GroupId == groupId && x.IsActive);

}