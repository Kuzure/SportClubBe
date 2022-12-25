using MediatR;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Coach.Query;

public class AddCoachToGroupQuery: IRequest<Response<string>>
{
    public Guid Id { get; set; }
    public IEnumerable<Guid>? GroupListId { get; set; }
}