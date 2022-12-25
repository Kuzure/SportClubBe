using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.CQRS.Coach.Query;

public class GetCoachByIdQueryHandler: IRequestHandler<GetCoachByIdQuery,CoachListModel>
{
    private readonly ICoachRepository _coachRepository;
    private readonly IMapper _mapper;

    public GetCoachByIdQueryHandler(ICoachRepository coachRepository, IMapper mapper)
    {
        _coachRepository = coachRepository;
        _mapper = mapper;
    }
    public async Task<CoachListModel> Handle(GetCoachByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _coachRepository.GetById(request.Id);
        var result = _mapper.Map<CoachListModel>(entity);
        return result;
    }
}