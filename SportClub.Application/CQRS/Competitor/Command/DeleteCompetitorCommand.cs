using MediatR;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Competitor.Command;

public class DeleteCompetitorCommand: IRequest<Response<string>>
{
    public Guid Id { get; set; } 
}