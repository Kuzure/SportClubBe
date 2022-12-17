using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure.Models;
using SportClub.Persistance;

namespace SportClub.Application.CQRS.Exercise.Query;

public class GetExerciseByIdQueryHandler: IRequestHandler<GetExerciseByIdQuery,ExerciseListModel>
{
    private readonly IExerciseRepository _exerciseRepository;
    private readonly IMapper _mapper;
    private readonly SportClubDbContext _dbContext;

    public GetExerciseByIdQueryHandler(IExerciseRepository exerciseRepository, IMapper mapper,SportClubDbContext dbContext)
    {
        _exerciseRepository = exerciseRepository;
        _mapper = mapper;
        _dbContext = dbContext;
    }
    public async Task<ExerciseListModel> Handle(GetExerciseByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _exerciseRepository.GetById(request.Id);
        var result = _mapper.Map<ExerciseListModel>(entity);
        return result;
    }
}