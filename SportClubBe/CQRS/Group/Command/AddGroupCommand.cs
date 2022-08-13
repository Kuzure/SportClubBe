using MediatR;

namespace SportClub.Api.CQRS.Group.Command
{
    public class AddGroupCommand : IRequest<SportClubBe.Entity.Group>
    {
        public string Name { get; set; } = null!;
    }
}
