using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;
using SportClub.Persistance;

namespace SportClub.Application.Repository;

public class ExerciseRepository : Repository<Exercise>, IExerciseRepository
{
    public ExerciseRepository(SportClubDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
    }
    public override async Task<IEnumerable<Exercise>> GetAll() =>
        await _dbContext.Exercises.Include(x => x.GroupExercises).ToListAsync();

    public async Task<IEnumerable<Exercise>> GetPageable(int page, int itemsPerPage) =>
        await _dbContext.Exercises.Include(x => x.GroupExercises).ThenInclude(x=>x.Group).OrderBy(x => x.Id)
            .Skip((page - 1) * itemsPerPage).Take(itemsPerPage).ToListAsync();

    public async Task<Exercise?> GetById(Guid id) => await _dbContext.Exercises.Include(x=>x.GroupExercises).FirstOrDefaultAsync(x => x.Id == id && x.IsActive);

}