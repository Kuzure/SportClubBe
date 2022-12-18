using MediatR;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Competitor.Query;

public class DisconnectCompetitorQuery: IRequest<Response<string>>
{
    public Guid Id { get; set; }
}