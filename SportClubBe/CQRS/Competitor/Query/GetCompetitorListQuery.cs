using MediatR;
using SportClub.Api.Dto;
using SportClub.Api.Extension;

namespace SportClub.Api.CQRS.Competitor.Query
{
    public class GetCompetitorListQuery : IRequest<Response<IEnumerable<CompetitorListModel>>>
    {
    }
}
