using AutoMapper;
using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure;
using SportClub.Infrastructure.Models;
using SportClub.Persistance;

namespace SportClub.Application.CQRS.Group.Query;

public class GetGroupListQueryHandler : IRequestHandler<GetGroupListQuery, PaginationResponse<IEnumerable<GroupListModel>>>
{
    private readonly IGroupRepository _groupRepository;
    private readonly IMapper _mapper;
    private readonly SportClubDbContext _dbContext;

    public GetGroupListQueryHandler(IGroupRepository groupRepository, IMapper mapper, SportClubDbContext dbContext)
    {
        _groupRepository = groupRepository;
        _mapper = mapper;
        _dbContext = dbContext;
    }

    public async Task<PaginationResponse<IEnumerable<GroupListModel>>> Handle(GetGroupListQuery request,
        CancellationToken cancellationToken)
    {
        var entities = await _groupRepository.GetPageable(request.Page, request.ItemsPerPage);
        var result = _mapper.Map<IEnumerable<GroupListModel>>(entities);
        return new PaginationResponse<IEnumerable<GroupListModel>>(result,
            _dbContext.Groups.Where(x => x.IsActive).Count(), request.Page, request.ItemsPerPage);
    }
}