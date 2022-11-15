using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure;
using SportClub.Infrastructure.Models;
using SportClub.Persistance;

namespace SportClub.Application.CQRS.Group.Query;

public class GetGroupsQueryHandler: IRequestHandler<GetGroupsQuery,IEnumerable<GroupListModel>>
{
    private readonly IGroupRepository _groupRepository;
    private readonly IMapper _mapper;
    private readonly SportClubDbContext _dbContext;

    public GetGroupsQueryHandler(IGroupRepository groupRepository, IMapper mapper, SportClubDbContext dbContext)
    {
        _groupRepository = groupRepository;
        _mapper = mapper;
        _dbContext = dbContext;
    }
    public async Task<IEnumerable<GroupListModel>> Handle(GetGroupsQuery request, CancellationToken cancellationToken)
    {
        var entities = await _groupRepository.GetAll();
        var result = _mapper.Map<IEnumerable<GroupListModel>>(entities);
        return result;
    }
}