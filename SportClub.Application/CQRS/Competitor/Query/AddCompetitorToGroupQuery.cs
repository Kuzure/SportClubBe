using MediatR;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Competitor.Query;

public class AddCompetitorToGroupQuery : IRequest<Response<string>>
{
    public Guid Id { get; set; }
    public Guid GroupId { get; set; }
}