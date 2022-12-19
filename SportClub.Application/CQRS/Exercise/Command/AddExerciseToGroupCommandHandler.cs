using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;

namespace SportClub.Application.CQRS.Exercise.Command;

public class AddExerciseToGroupCommandHandler: IRequestHandler<AddExerciseToGroupCommand, SportClub.Domain.Entity.Exercise>
{
    private readonly IExerciseRepository _repository;
    private readonly IMapper _mapper;
    public AddExerciseToGroupCommandHandler(IExerciseRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<SportClub.Domain.Entity.Exercise> Handle(AddExerciseToGroupCommand request, CancellationToken cancellationToken)
    {
        foreach (var exerciseId in request.Exercises)
        {
            var entity =await _repository.GetById(exerciseId);
            if (entity == null) continue;
            var groupExercise = new GroupExercise
            {
                ExercisesId= entity.Id,
                GroupId = request.GroupId
            };
            entity.GroupExercises.Add(groupExercise);
            await _repository.Update(entity);
        }

        return default!;
    }
}