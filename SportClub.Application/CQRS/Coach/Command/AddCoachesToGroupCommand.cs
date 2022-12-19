using MediatR;

namespace SportClub.Application.CQRS.Coach.Command;

public class AddCoachesToGroupCommand: IRequest<Domain.Entity.Coach>
{
    public Guid GroupId { set; get; }
    public IEnumerable<Guid> Coaches { get; set; }
}