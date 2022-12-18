using MediatR;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Coach.Query;

public class DisconnectCoachQuery: IRequest<Response<string>>
{
    public Guid Id { get; set; }
}