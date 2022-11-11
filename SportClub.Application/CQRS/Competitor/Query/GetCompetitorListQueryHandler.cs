using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure;
using SportClub.Infrastructure.Models;
using SportClub.Persistance;

namespace SportClub.Application.CQRS.Competitor.Query
{
    public class GetCompetitorListQueryHandler : IRequestHandler<GetCompetitorListQuery, PaginationResponse<IEnumerable<CompetitorListModel>>>
    {
        private readonly ICompetitorRepository _competitorRepository;
        private readonly IMapper _mapper;
        private readonly SportClubDbContext _dbContext;

        public GetCompetitorListQueryHandler(ICompetitorRepository competitorRepository, IMapper mapper,SportClubDbContext dbContext)
        {
            _competitorRepository = competitorRepository;
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<PaginationResponse<IEnumerable<CompetitorListModel>>> Handle(GetCompetitorListQuery request, CancellationToken cancellationToken)
        {
            var entities = await _competitorRepository.GetPageable(request.Page,request.ItemsPerPage);
            var result = _mapper.Map<IEnumerable<CompetitorListModel>>(entities);
            return new PaginationResponse<IEnumerable<CompetitorListModel>>(result,
                _dbContext.Competitors.Where(x => x.IsActive).Count(), request.Page, request.ItemsPerPage);

        }
    }
}
