﻿using AutoMapper;
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

    public override async Task<IEnumerable<Group>> GetAll() =>
        await DbContext.Groups.Where(x=>x.IsActive).ToListAsync();

    public async Task<IEnumerable<Group>> GetPageable(int page, int itemsPerPage) =>
        await DbContext.Groups.OrderBy(x => x.Id)
            .Skip((page - 1) * itemsPerPage).Take(itemsPerPage).ToListAsync();
}