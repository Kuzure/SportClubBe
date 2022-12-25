using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Competitor.Command;

public class DeleteCompetitorCommandHandler: IRequestHandler<DeleteCompetitorCommand, Response<string>>
{
    private readonly IRepository<SportClub.Domain.Entity.Competitor> _repository;

    public DeleteCompetitorCommandHandler(IRepository<SportClub.Domain.Entity.Competitor> repository)
    {
        _repository = repository;
    }

    public async Task<Response<string>> Handle(DeleteCompetitorCommand request, CancellationToken cancellationToken)
    {
        await _repository.Delete(request.Id);
        return default!;
    }
}