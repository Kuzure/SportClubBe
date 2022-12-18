namespace SportClub.Infrastructure.Models;

public class GroupDetailsModel
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public IEnumerable<CompetitorModel?>? CompetitorModels { get; set; }
    public IEnumerable<CoachListModel?>? CoachListModels { get; set; }
    public IEnumerable<ExerciseListModel?>? ExerciseListModels { get; set; }
}