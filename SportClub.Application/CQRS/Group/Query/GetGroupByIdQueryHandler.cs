using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure.Models;
using SportClub.Persistance;

namespace SportClub.Application.CQRS.Group.Query;

public class GetGroupByIdQueryHandler : IRequestHandler<GetGroupByIdQuery, GroupDetailsModel>
{
    private readonly IGroupRepository _groupRepository;
    private readonly ICompetitorRepository _competitorRepository;
    private readonly IMapper _mapper;
    private readonly SportClubDbContext _dbContext;

    public GetGroupByIdQueryHandler(IGroupRepository groupRepository, IMapper mapper, SportClubDbContext dbContext,ICompetitorRepository competitorRepository)
    {
        _groupRepository = groupRepository;
        _mapper = mapper;
        _dbContext = dbContext;
        _competitorRepository = competitorRepository;
    }

    public async Task<GroupDetailsModel> Handle(GetGroupByIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _groupRepository.GetById(request.Id);
        var result = _mapper.Map<GroupDetailsModel>(entities);
        var competitors = await _competitorRepository.GetByGroupId(request.Id);
        var  competitorModels= _mapper.Map<IEnumerable<CompetitorModel>>(competitors);
        result.CompetitorModels = competitorModels;
        return result;
    }
}