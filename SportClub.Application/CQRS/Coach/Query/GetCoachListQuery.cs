using MediatR;
using SportClub.Infrastructure;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.CQRS.Coach.Query;

public class GetCoachListQuery: IRequest<PaginationResponse<IEnumerable<CoachListModel>>>
{
    private const int MaxItemsPage = 50;
    private int _itemsPerPage;
    public int Page { get; set; } = 1;

    public int ItemsPerPage
    {
        get => _itemsPerPage;
        set => _itemsPerPage = value > MaxItemsPage ? MaxItemsPage : value;
    }
}