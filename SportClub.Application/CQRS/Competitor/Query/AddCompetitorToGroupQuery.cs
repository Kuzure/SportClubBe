using MediatR;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Group.Query;

public class AddCompetitorToGroupQuery : IRequest<Response<string>>
{
    public Guid id { get; set; }
    public Guid GroupId { get; set; }
}