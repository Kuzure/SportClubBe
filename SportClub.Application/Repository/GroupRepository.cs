using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;
using SportClub.Persistance;

namespace SportClub.Application.Repository;

public class GroupRepository : Repository<Group>, IGroupRepository
{
    public GroupRepository(SportClubDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
    }

    public async Task<IEnumerable<Group>> GetPageable(int page, int itemsPerPage) =>
        await _dbContext.Groups.OrderBy(x => x.Id)
            .Skip((page - 1) * itemsPerPage).Take(itemsPerPage).ToListAsync();
}