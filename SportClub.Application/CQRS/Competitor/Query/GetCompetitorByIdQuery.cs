using MediatR;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.CQRS.Competitor.Query;

public class GetCompetitorByIdQuery: IRequest<CompetitorListModel>
{
    public Guid Id { get; set; }
}