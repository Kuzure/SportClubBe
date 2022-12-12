using MediatR;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.CQRS.Coach.Query;

public class GetCoachByIdQuery: IRequest<CoachListModel>
{
    public Guid Id { get; set; }
}