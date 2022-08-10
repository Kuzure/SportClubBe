using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SportClub.Api.Interface;
using SportClubBe.Entity;
using System.Linq.Expressions;

namespace SportClub.Api.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(SportClubDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public override async Task<User> GetByPredicate(Expression<Func<User, bool>> expression) =>
            await _dbContext.Users.Include(x => x.Role).Include(x => x.Identity).FirstOrDefaultAsync(expression);
    }
}
