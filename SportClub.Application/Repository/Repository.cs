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
        protected readonly SportClubDbContext _dbContext;
        protected readonly IMapper _mapper;

        public Repository(SportClubDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public virtual async Task<TEntity> Save(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<TEntity> Update<TKey, TModel>(TKey id, TModel model)
        {
            var existingEntity = await _dbContext.Set<TEntity>().FindAsync(id);
            if (existingEntity == null)
            {
                throw new Exception("Entity With provided Id does not exist");
            }
            _mapper.Map(model, existingEntity);
            await _dbContext.SaveChangesAsync();

            return existingEntity;
        }
        public virtual async Task<TEntity> Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task Delete<TKey>(TKey id)
        {
            var existingEntity = await _dbContext.Set<TEntity>().FindAsync(id);
            if (existingEntity != null)
            {
                _dbContext.Remove(existingEntity);
                await _dbContext.SaveChangesAsync();
            }
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            var entities = await _dbContext.Set<TEntity>().ToListAsync();
            return entities;
        }

        public virtual async Task<TEntity?> GetById<TKey>(TKey id) =>
            await _dbContext.Set<TEntity>().FindAsync(id);

        public virtual async Task<TEntity?> GetByPredicate(Expression<Func<TEntity, bool>> expression) =>
            await _dbContext.Set<TEntity>().Where(expression).FirstOrDefaultAsync();
    }
}
