using SportClub.Domain.Entity;
using System.Linq.Expressions;

namespace SportClub.Application.Interface
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task Delete<TKey>(TKey id);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity?> GetById<TKey>(TKey id);
        Task<TEntity> Save(TEntity entity);
        Task<TEntity> Update(TEntity entity); 
        Task<TEntity?> GetByPredicate(Expression<Func<TEntity, bool>> expression);
    }
}
