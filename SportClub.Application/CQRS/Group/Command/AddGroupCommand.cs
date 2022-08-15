using MediatR;

namespace SportClub.Application.CQRS.Group.Command
{
    public class AddGroupCommand : IRequest<SportClub.Domain.Entity.Group>
    {
        public string Name { get; set; } = null!;
    }
}
