using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.CQRS.Competitor.Query;

public class GetCompetitorByIdQueryHandler: IRequestHandler<GetCompetitorByIdQuery,CompetitorDetail>
{
    private readonly ICompetitorRepository _competitorRepository;
    private readonly IMapper _mapper;

    public GetCompetitorByIdQueryHandler(ICompetitorRepository competitorRepository, IMapper mapper)
    {
        _competitorRepository = competitorRepository;
        _mapper = mapper;
    }
    public async Task<CompetitorDetail> Handle(GetCompetitorByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _competitorRepository.GetById(request.Id);
        var result = _mapper.Map<CompetitorDetail>(entity);
        return result;
    }
}