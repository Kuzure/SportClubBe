﻿using AutoMapper;
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
        await DbContext.Coaches.Include(x => x.CoachGroups).Include(x=>x.Identity).ToListAsync();

    public async Task<IEnumerable<Coach>> GetPageable(int page, int itemsPerPage) =>
        await DbContext.Coaches.Include(x => x.CoachGroups).ThenInclude(x=>x.Group).Include(x => x.Identity).OrderBy(x => x.Id)
            .Skip((page - 1) * itemsPerPage).Take(itemsPerPage).ToListAsync();
    
    public async Task<Coach?> GetById(Guid id) => await DbContext.Coaches.Include(x=>x.CoachGroups).ThenInclude(x=>x.Group).Include(x=>x.Identity).FirstOrDefaultAsync(x => x.Id == id && x.IsActive);
    public async Task<IEnumerable<Coach>> GetCoachByGroupId(Guid id) =>
        await DbContext.Coaches.Include(x => x.CoachGroups).ThenInclude(x=>x.Group).Include(x => x.Identity)
            .Where(x => x.CoachGroups.Any(y=>y.GroupId==id)&& x.IsActive).ToListAsync();
    public async Task<IEnumerable<Coach>> GetAllWithNoGroup(Guid groupId) =>
        await DbContext.Coaches.Include(x => x.CoachGroups).ThenInclude(x=>x.Group).Include(x => x.Identity).Where(x => x.CoachGroups.Any(y=>y.GroupId==groupId)==false).ToListAsync();

}