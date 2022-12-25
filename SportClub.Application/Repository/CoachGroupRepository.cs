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
    public async Task<CoachGroup?> GetIfExistByGroupId(Guid groupId) => await DbContext.CoachGroups.Include(x=>x.Group).FirstOrDefaultAsync(x => x.GroupId == groupId && x.IsActive);

}