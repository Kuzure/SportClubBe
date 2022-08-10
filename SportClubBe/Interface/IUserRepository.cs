using SportClubBe.Entity;
using System.Linq.Expressions;

namespace SportClub.Api.Interface
{
    public interface IUserRepository : IRepository<User>
    {
        new Task<User> GetByPredicate(Expression<Func<User, bool>> expression);
    }
}
