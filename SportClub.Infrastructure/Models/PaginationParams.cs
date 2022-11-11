namespace SportClub.Infrastructure.Models;

public class PaginationParams
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