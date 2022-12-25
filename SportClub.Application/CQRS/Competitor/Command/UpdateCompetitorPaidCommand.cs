using MediatR;

namespace SportClub.Application.CQRS.Competitor.Command
{
    public class UpdateCompetitorPaidCommand : IRequest<SportClub.Domain.Entity.Competitor>
    {
        public Guid Id { get; set; }
        public bool IsPaid { get; set; }
    }
}