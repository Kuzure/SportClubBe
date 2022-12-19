using MediatR;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.CQRS.Competitor.Query;

public class GetCompetitorsQuery: IRequest<IEnumerable<CompetitorModel>>
{
}