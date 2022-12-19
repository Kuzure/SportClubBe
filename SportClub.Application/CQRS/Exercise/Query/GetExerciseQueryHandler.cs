using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure.Models;
using SportClub.Persistance;

namespace SportClub.Application.CQRS.Exercise.Query;

public class GetExerciseQueryHandler: IRequestHandler<GetExerciseQuery, IEnumerable<ExerciseListModel>>
{
    private readonly IExerciseRepository _exerciseRepository;
    private readonly IMapper _mapper;
    private readonly SportClubDbContext _dbContext;

    public GetExerciseQueryHandler(IExerciseRepository exerciseRepository, IMapper mapper,SportClubDbContext dbContext)
    {
        _exerciseRepository = exerciseRepository;
        _mapper = mapper;
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<ExerciseListModel>> Handle(GetExerciseQuery request, CancellationToken cancellationToken)
    {
        var entities = await _exerciseRepository.GetAllWithNoGroup(request.GroupId);
        var result = _mapper.Map<IEnumerable<ExerciseListModel>>(entities);
        return  result;
    }
}