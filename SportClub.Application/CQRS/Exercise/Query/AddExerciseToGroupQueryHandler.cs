using MediatR;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Exercise.Query;

public class AddExerciseToGroupQueryHandler: IRequestHandler<AddExerciseToGroupQuery, Response<string>>
{
    private readonly IExerciseRepository _exerciseRepository;

    public AddExerciseToGroupQueryHandler(IExerciseRepository exerciseRepository)
    {
        _exerciseRepository = exerciseRepository;
    }
    public async Task<Response<string>> Handle(AddExerciseToGroupQuery query, CancellationToken cancellationToken)
    {
        var entity = await _exerciseRepository.GetById(query.Id);
        if (entity == null)
            return default!;
        var groupExercises = new List<GroupExercise>();
        if (query.GroupListId != null)
            foreach (var guid in query.GroupListId)
            {
                var groupExercise= new GroupExercise();
                groupExercise.ExercisesId = query.Id;
                groupExercise.GroupId = guid;
                groupExercises.Add(groupExercise);
            }

        entity.GroupExercises = groupExercises;
        await _exerciseRepository.Update(entity);
        return default!;
    }
}