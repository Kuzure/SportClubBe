using MediatR;

namespace SportClub.Application.CQRS.Group.Command;

public class UpdateGroupCommand: IRequest<SportClub.Domain.Entity.Group>
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
}