using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Competitor.Query;

public class AddCompetitorToGroupQueryHandler : IRequestHandler<AddCompetitorToGroupQuery,Response<string>>
{
    private readonly IRepository<SportClub.Domain.Entity.Competitor> _repository;

    public AddCompetitorToGroupQueryHandler(IRepository<SportClub.Domain.Entity.Competitor> repository)
    {
        _repository = repository;
    }

    public async Task<Response<string>> Handle(AddCompetitorToGroupQuery query, CancellationToken cancellationToken)
    {
        var entity =await _repository.GetById(query.Id);
        if (entity == null)
            return default!;
        entity.GroupId = query.GroupId;
        await _repository.Update(entity);
        return default!;
    }
}