using MediatR;
using SportClub.Infrastructure;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.CQRS.Competitor.Query
{
    public class GetCompetitorListQuery : IRequest<Response<IEnumerable<CompetitorListModel>>>
    {
    }
}
