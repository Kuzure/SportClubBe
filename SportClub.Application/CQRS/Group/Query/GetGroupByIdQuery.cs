using MediatR;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.CQRS.Group.Query;

public class GetGroupByIdQuery: IRequest<GroupDetailsModel>
{
    public Guid Id { get; set; }
}