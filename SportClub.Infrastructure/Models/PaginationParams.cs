namespace SportClub.Infrastructure.Models;

public class PaginationParams
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