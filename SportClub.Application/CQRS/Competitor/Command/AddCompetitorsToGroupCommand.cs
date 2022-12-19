using MediatR;

namespace SportClub.Application.CQRS.Competitor.Command;

public class AddCompetitorsToGroupCommand: IRequest<Domain.Entity.Competitor>
{
    public Guid GroupId { set; get; }
    public IEnumerable<Guid> Competitors { get; set; }
}