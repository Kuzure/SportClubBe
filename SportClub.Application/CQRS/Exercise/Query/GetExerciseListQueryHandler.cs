using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure;
using SportClub.Infrastructure.Models;
using SportClub.Persistance;

namespace SportClub.Application.CQRS.Exercise.Query;

public class GetExerciseListQueryHandler: IRequestHandler<GetExerciseListQuery, PaginationResponse<IEnumerable<ExerciseListModel>>>
{
    private readonly IExerciseRepository _exerciseRepository;
    private readonly IMapper _mapper;
    private readonly SportClubDbContext _dbContext;

    public GetExerciseListQueryHandler(IExerciseRepository exerciseRepository, IMapper mapper,SportClubDbContext dbContext)
    {
        _exerciseRepository = exerciseRepository;
        _mapper = mapper;
        _dbContext = dbContext;
    }

    public async Task<PaginationResponse<IEnumerable<ExerciseListModel>>> Handle(GetExerciseListQuery request, CancellationToken cancellationToken)
    {
        var entities = await _exerciseRepository.GetPageable(request.Page,request.ItemsPerPage);
        var result = _mapper.Map<IEnumerable<ExerciseListModel>>(entities);
        return new PaginationResponse<IEnumerable<ExerciseListModel>>(result,
            _dbContext.Exercises.Where(x => x.IsActive).Count(), request.Page, request.ItemsPerPage);

    }
}