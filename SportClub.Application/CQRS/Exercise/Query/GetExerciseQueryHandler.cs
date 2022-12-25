using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.CQRS.Exercise.Query;

public class GetExerciseQueryHandler: IRequestHandler<GetExerciseQuery, IEnumerable<ExerciseListModel>>
{
    private readonly IExerciseRepository _exerciseRepository;
    private readonly IMapper _mapper;

    public GetExerciseQueryHandler(IExerciseRepository exerciseRepository, IMapper mapper)
    {
        _exerciseRepository = exerciseRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ExerciseListModel>> Handle(GetExerciseQuery request, CancellationToken cancellationToken)
    {
        var entities = await _exerciseRepository.GetAllWithNoGroup(request.GroupId);
        var result = _mapper.Map<IEnumerable<ExerciseListModel>>(entities);
        return  result;
    }
}