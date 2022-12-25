using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;
using SportClub.Persistance;
using System.Linq.Expressions;

namespace SportClub.Application.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(SportClubDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public override async Task<User?> GetByPredicate(Expression<Func<User, bool>> expression) =>
            await DbContext.Users.Include(x => x.Role).Include(x => x.Identity).FirstOrDefaultAsync(expression);
    }
}
