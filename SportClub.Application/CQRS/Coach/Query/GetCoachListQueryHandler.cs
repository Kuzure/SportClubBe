using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure;
using SportClub.Infrastructure.Models;
using SportClub.Persistance;

namespace SportClub.Application.CQRS.Coach.Query;

public class GetCoachListQueryHandler: IRequestHandler<GetCoachListQuery, PaginationResponse<IEnumerable<CoachListModel>>>
{
    private readonly ICoachRepository _coachRepository;
    private readonly IMapper _mapper;
    private readonly SportClubDbContext _dbContext;

    public GetCoachListQueryHandler(ICoachRepository coachRepository, IMapper mapper,SportClubDbContext dbContext)
    {
        _coachRepository = coachRepository;
        _mapper = mapper;
        _dbContext = dbContext;
    }

    public async Task<PaginationResponse<IEnumerable<CoachListModel>>> Handle(GetCoachListQuery request, CancellationToken cancellationToken)
    {
        var entities = await _coachRepository.GetPageable(request.Page,request.ItemsPerPage);
        var result = _mapper.Map<IEnumerable<CoachListModel>>(entities);
        return new PaginationResponse<IEnumerable<CoachListModel>>(result,
            _dbContext.Coaches.Count(x => x.IsActive), request.Page, request.ItemsPerPage);

    }
}