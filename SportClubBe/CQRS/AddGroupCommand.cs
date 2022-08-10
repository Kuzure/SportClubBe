using MediatR;
using SportClubBe.Entity;

namespace SportClub.Api.CQRS
{
    public class AddGroupCommand : IRequest<Group>
    {
        public string Name { get; set; } = null!;
    }
}
