using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.CQRS.Group.Query;

public class GetGroupsQueryHandler: IRequestHandler<GetGroupsQuery,IEnumerable<GroupListModel>>
{
    private readonly IGroupRepository _groupRepository;
    private readonly IMapper _mapper;

    public GetGroupsQueryHandler(IGroupRepository groupRepository, IMapper mapper)
    {
        _groupRepository = groupRepository;
        _mapper = mapper;
    }
    public async Task<IEnumerable<GroupListModel>> Handle(GetGroupsQuery request, CancellationToken cancellationToken)
    {
        var entities = await _groupRepository.GetAll();
        var result = _mapper.Map<IEnumerable<GroupListModel>>(entities);
        return result;
    }
}