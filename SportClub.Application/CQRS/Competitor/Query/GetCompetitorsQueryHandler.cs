using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure;
using SportClub.Infrastructure.Models;
using SportClub.Persistance;

namespace SportClub.Application.CQRS.Competitor.Query;

public class GetCompetitorsQueryHandler: IRequestHandler<GetCompetitorsQuery, IEnumerable<CompetitorModel>>
{
    private readonly ICompetitorRepository _competitorRepository;
    private readonly IMapper _mapper;
    private readonly SportClubDbContext _dbContext;

    public GetCompetitorsQueryHandler(ICompetitorRepository competitorRepository, IMapper mapper,SportClubDbContext dbContext)
    {
        _competitorRepository = competitorRepository;
        _mapper = mapper;
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<CompetitorModel>> Handle(GetCompetitorsQuery request, CancellationToken cancellationToken)
    {
        var entities = await _competitorRepository.GetAllWithNoGroup();
        var result = _mapper.Map<IEnumerable<CompetitorModel>>(entities);
        return  result;

    }
}