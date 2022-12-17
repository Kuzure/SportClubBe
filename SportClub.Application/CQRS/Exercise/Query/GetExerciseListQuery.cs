using MediatR;
using SportClub.Infrastructure;
using SportClub.Infrastructure.Models;

namespace SportClub.Application.CQRS.Exercise.Query;

public class GetExerciseListQuery: IRequest<PaginationResponse<IEnumerable<ExerciseListModel>>>
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