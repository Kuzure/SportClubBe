using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;
using SportClub.Persistance;
using System.Linq.Expressions;

namespace SportClub.Application.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly SportClubDbContext DbContext;
        protected readonly IMapper Mapper;

        public Repository(SportClubDbContext dbContext, IMapper mapper)
        {
            DbContext = dbContext;
            Mapper = mapper;
        }

        public virtual async Task<TEntity> Save(TEntity entity)
        {
            await DbContext.Set<TEntity>().AddAsync(entity);
            await DbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<TEntity> Update<TKey, TModel>(TKey id, TModel model)
        {
            var existingEntity = await DbContext.Set<TEntity>().FindAsync(id);
            if (existingEntity == null)
            {
                throw new Exception("Entity With provided Id does not exist");
            }
            Mapper.Map(model, existingEntity);
            await DbContext.SaveChangesAsync();

            return existingEntity;
        }
        public virtual async Task<TEntity> Update(TEntity entity)
        {
            DbContext.Set<TEntity>().Update(entity);
            await DbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task Delete<TKey>(TKey id)
        {
            var existingEntity = await DbContext.Set<TEntity>().FindAsync(id);
            if (existingEntity != null)
            {
                DbContext.Remove(existingEntity);
                await DbContext.SaveChangesAsync();
            }
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            var entities = await DbContext.Set<TEntity>().ToListAsync();
            return entities;
        }

        public virtual async Task<TEntity?> GetById<TKey>(TKey id) =>
            await DbContext.Set<TEntity>().FindAsync(id);

        public virtual async Task<TEntity?> GetByPredicate(Expression<Func<TEntity, bool>> expression) =>
            await DbContext.Set<TEntity>().Where(expression).FirstOrDefaultAsync();
    }
}
