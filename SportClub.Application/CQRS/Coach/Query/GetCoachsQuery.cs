using MediatR;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.CQRS.Coach.Query;

public class GetCoachesQuery: IRequest<IEnumerable<CoachListModel>>
{
    public Guid GroupId { set; get; }
}