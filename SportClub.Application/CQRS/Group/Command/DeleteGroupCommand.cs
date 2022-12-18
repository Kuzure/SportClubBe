using MediatR;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Group.Command;

public class DeleteGroupCommand: IRequest<Response<string>>
{
    public Guid Id { get; set; } 
}