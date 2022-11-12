using MediatR;
using SportClub.Infrastructure;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.CQRS.Group.Query;

public class GetGroupListQuery: IRequest<PaginationResponse<IEnumerable<GroupListModel>>>
{
    private const int maxItemsPage = 50;
    private int itemsPerPage;
    public int Page { get; set; } = 1;

    public int ItemsPerPage
    {
        get => itemsPerPage;
        set => itemsPerPage = value > maxItemsPage ? maxItemsPage : value;
    }
}