using MediatR;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Coach.Command;

public class DeleteCoachCommand: IRequest<Response<string>>
{
    public Guid Id { get; set; } 
}