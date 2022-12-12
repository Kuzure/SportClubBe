using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure.Models;
using SportClub.Persistance;

namespace SportClub.Application.CQRS.Coach.Query;

public class GetCoachByIdQueryHandler: IRequestHandler<GetCoachByIdQuery,CoachListModel>
{
    private readonly ICoachRepository _coachRepository;
    private readonly IMapper _mapper;
    private readonly SportClubDbContext _dbContext;

    public GetCoachByIdQueryHandler(ICoachRepository coachRepository, IMapper mapper,SportClubDbContext dbContext)
    {
        _coachRepository = coachRepository;
        _mapper = mapper;
        _dbContext = dbContext;
    }
    public async Task<CoachListModel> Handle(GetCoachByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _coachRepository.GetById(request.Id);
        var result = _mapper.Map<CoachListModel>(entity);
        return result;
    }
}