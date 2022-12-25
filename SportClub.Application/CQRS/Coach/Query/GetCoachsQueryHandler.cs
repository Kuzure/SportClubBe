using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure.Models;
using SportClub.Persistance;

namespace SportClub.Application.CQRS.Coach.Query;

public class GetCoachesQueryHandler: IRequestHandler<GetCoachesQuery, IEnumerable<CoachListModel>>
{
    private readonly ICoachRepository _coachRepository;
    private readonly IMapper _mapper;

    public GetCoachesQueryHandler(ICoachRepository coachRepository, IMapper mapper)
    {
        _coachRepository = coachRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CoachListModel>> Handle(GetCoachesQuery request, CancellationToken cancellationToken)
    {
        var entities = await _coachRepository.GetAllWithNoGroup(request.GroupId);
        var result = _mapper.Map<IEnumerable<CoachListModel>>(entities);
        return  result;
    }
}