using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.CQRS.Exercise.Query;

public class GetExerciseByIdQueryHandler: IRequestHandler<GetExerciseByIdQuery,ExerciseListModel>
{
    private readonly IExerciseRepository _exerciseRepository;
    private readonly IMapper _mapper;

    public GetExerciseByIdQueryHandler(IExerciseRepository exerciseRepository, IMapper mapper)
    {
        _exerciseRepository = exerciseRepository;
        _mapper = mapper;
    }
    public async Task<ExerciseListModel> Handle(GetExerciseByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _exerciseRepository.GetById(request.Id);
        var result = _mapper.Map<ExerciseListModel>(entity);
        return result;
    }
}