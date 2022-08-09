namespace SportClub.Domain.Entity
{
    public class GroupExercise : BaseEntity<Guid>
    {
        public Guid GroupId { get; set; }
        public virtual Group Group { get; set; } = null!;
        public Guid ExercisesId { get; set; }
        public virtual Exercise Exercise { get; set; } = null!;
    }
}
