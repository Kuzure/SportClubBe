using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure;
using SportClub.Infrastructure.Models;
using SportClub.Persistance;

namespace SportClub.Application.CQRS.Competitor.Query;

public class GetCompetitorByIdQueryHandler: IRequestHandler<GetCompetitorByIdQuery,CompetitorListModel>
{
    private readonly ICompetitorRepository _competitorRepository;
    private readonly IMapper _mapper;
    private readonly SportClubDbContext _dbContext;

    public GetCompetitorByIdQueryHandler(ICompetitorRepository competitorRepository, IMapper mapper,SportClubDbContext dbContext)
    {
        _competitorRepository = competitorRepository;
        _mapper = mapper;
        _dbContext = dbContext;
    }
    public async Task<CompetitorListModel> Handle(GetCompetitorByIdQuery request, CancellationToken cancellationToken)
    {
        var entiti = await _competitorRepository.GetById(request.Id);
        var result = _mapper.Map<CompetitorListModel>(entiti);
        return result;
    }
}