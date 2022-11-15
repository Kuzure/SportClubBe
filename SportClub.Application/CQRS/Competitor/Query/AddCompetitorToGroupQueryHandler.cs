using AutoMapper;
using MediatR;
using SportClub.Application.CQRS.Group.Query;
using SportClub.Application.Interface;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Competitor.Query;

public class AddCompetitorToGroupQueryHandler : IRequestHandler<AddCompetitorToGroupQuery,Response<string>>
{
    private readonly IRepository<SportClub.Domain.Entity.Competitor> _repository;
    private readonly IMapper _mapper;
    public AddCompetitorToGroupQueryHandler(IRepository<SportClub.Domain.Entity.Competitor> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<Response<string>> Handle(AddCompetitorToGroupQuery query, CancellationToken cancellationToken)
    {
        var entity =await _repository.GetById(query.id);
        if (entity == null)
            return default!;
        entity.GroupId = query.GroupId;
        await _repository.Update(entity);
        return default!;
    }
}