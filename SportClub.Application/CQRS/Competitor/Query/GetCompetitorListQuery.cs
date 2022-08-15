using MediatR;
using SportClub.Application.Dto;
using SportClub.Application.Extension;

namespace SportClub.Application.CQRS.Competitor.Query
{
    public class GetCompetitorListQuery : IRequest<Response<IEnumerable<CompetitorListModel>>>
    {
    }
}
