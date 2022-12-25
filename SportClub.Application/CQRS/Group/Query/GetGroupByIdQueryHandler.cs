using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.CQRS.Group.Query;

public class GetGroupByIdQueryHandler : IRequestHandler<GetGroupByIdQuery, GroupDetailsModel>
{
    private readonly IGroupRepository _groupRepository;
    private readonly ICompetitorRepository _competitorRepository;
    private readonly ICoachRepository _coachRepository;
    private readonly IMapper _mapper;
    private readonly IExerciseRepository _exerciseRepository;

    public GetGroupByIdQueryHandler(IExerciseRepository exerciseRepository,ICoachRepository coachRepository,IGroupRepository groupRepository, IMapper mapper,ICompetitorRepository competitorRepository)
    {
        _exerciseRepository = exerciseRepository;
        _coachRepository = coachRepository;
        _groupRepository = groupRepository;
        _mapper = mapper;
        _competitorRepository = competitorRepository;
    }

    public async Task<GroupDetailsModel> Handle(GetGroupByIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _groupRepository.GetById(request.Id);
        var result = _mapper.Map<GroupDetailsModel>(entities);
        var competitors = await _competitorRepository.GetByGroupId(request.Id);
        var  competitorModels= _mapper.Map<IEnumerable<CompetitorModel>>(competitors);
        var coaches = await _coachRepository.GetCoachByGroupId(request.Id);
        var  coachModels= _mapper.Map<IEnumerable<CoachListModel>>(coaches);
        var exercise = await _exerciseRepository.GetByGroupId(request.Id);
        var  exerciseModels= _mapper.Map<IEnumerable<ExerciseListModel>>(exercise);
        result.CompetitorModels = competitorModels;
        result.CoachListModels = coachModels;
        result.ExerciseListModels = exerciseModels;
        return result;
    }
}