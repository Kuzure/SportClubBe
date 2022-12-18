﻿using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Exercise.Query;

public class DisconnectExerciseQueryHandler: IRequestHandler<DisconnectExerciseQuery,Response<string>>
{
    private readonly IExerciseRepository _repository;
    private readonly IMapper _mapper;
    public DisconnectExerciseQueryHandler(IExerciseRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<Response<string>> Handle(DisconnectExerciseQuery query, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetById(query.Id);
        if (entity == null)
            return default!;
        var exercises = new List<GroupExercise>();
        foreach (var exercise in entity.GroupExercises)
        {
            if (exercise.ExercisesId == query.Id)
            {
                exercise.GroupId = null;
            }

            exercises.Add(exercise);
            
        }

        entity.GroupExercises = exercises;
        await _repository.Update(entity);
        return default!;
    }
}