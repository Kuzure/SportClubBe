using SportClub.Domain.Entity;
using System.Linq.Expressions;

namespace SportClub.Application.Interface
{
    public interface IUserRepository : IRepository<User>
    {
        new Task<User?> GetByPredicate(Expression<Func<User, bool>> expression);
    }
}
