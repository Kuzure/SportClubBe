using MediatR;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.CQRS.Group.Query;

public class GetGroupsQuery : IRequest<IEnumerable<GroupListModel>>
{
}