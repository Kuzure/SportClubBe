namespace SportClub.Infrastructure.Models;

public class ExerciseListModel
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int Repetitions { get; set; }
    public ICollection<ExerciseGroupListModel>? GroupExercises { get; set; }
}