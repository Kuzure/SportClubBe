using MediatR;
using SportClub.Application.Interface;
using SportClub.Persistance;

namespace SportClub.Application.CQRS.Exercise.Command;

public class UpdateExerciseCommandHandler: IRequestHandler<UpdateExerciseCommand, SportClub.Domain.Entity.Exercise>
{
    private readonly SportClubDbContext _dbContext;
    private readonly IExerciseRepository _exerciseRepository;
    public UpdateExerciseCommandHandler(IExerciseRepository exerciseRepository,SportClubDbContext dbContext)
    {
        _exerciseRepository = exerciseRepository;
        _dbContext = dbContext;
    }

    public async Task<SportClub.Domain.Entity.Exercise> Handle(UpdateExerciseCommand request, CancellationToken cancellationToken)
    {

        var exercise = await _exerciseRepository.GetById(request.Id);
        if (exercise == null) return default!;
        exercise.Name = request.Name;
        exercise.Description = request.Description;
        exercise.Repetitions = request.Repetitions;
        await _exerciseRepository.Update(exercise);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return default!;
    }
}