using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.CQRS.Competitor.Query;

public class GetCompetitorsQueryHandler: IRequestHandler<GetCompetitorsQuery, IEnumerable<CompetitorModel>>
{
    private readonly ICompetitorRepository _competitorRepository;
    private readonly IMapper _mapper;

    public GetCompetitorsQueryHandler(ICompetitorRepository competitorRepository, IMapper mapper)
    {
        _competitorRepository = competitorRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CompetitorModel>> Handle(GetCompetitorsQuery request, CancellationToken cancellationToken)
    {
        var entities = await _competitorRepository.GetAllWithNoGroup();
        var result = _mapper.Map<IEnumerable<CompetitorModel>>(entities);
        return  result;

    }
}