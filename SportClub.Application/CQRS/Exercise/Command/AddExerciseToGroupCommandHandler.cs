using MediatR;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;

namespace SportClub.Application.CQRS.Exercise.Command;

public class AddExerciseToGroupCommandHandler: IRequestHandler<AddExerciseToGroupCommand, SportClub.Domain.Entity.Exercise>
{
    private readonly IExerciseRepository _repository;

    public AddExerciseToGroupCommandHandler(IExerciseRepository repository)
    {
        _repository = repository;
    }

    public async Task<SportClub.Domain.Entity.Exercise> Handle(AddExerciseToGroupCommand request, CancellationToken cancellationToken)
    {
        if (request.Exercises == null) return default!;
        foreach (var exerciseId in request.Exercises)
        {
            var entity = await _repository.GetById(exerciseId);
            if (entity == null) continue;
            var groupExercise = new GroupExercise
            {
                ExercisesId = entity.Id,
                GroupId = request.GroupId
            };
            entity.GroupExercises.Add(groupExercise);
            await _repository.Update(entity);
        }

        return default!;
    }
}