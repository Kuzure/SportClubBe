using SportClub.Domain.Entity;

namespace SportClub.Application.Interface;

public interface IExerciseRepository: IRepository<Exercise>
{ 
    new Task<IEnumerable<Exercise>> GetAll();
    Task<Exercise?> GetById(Guid id);
    Task<IEnumerable<Exercise>> GetPageable(int page, int itemsPerPage);
    new Task<Exercise> Update(Exercise exercise);
}