namespace SportClubBe.Entity
{
    public class Group : BaseEntity<Guid>
    {
        public string Name { get; set; } = null!;
        public virtual IEnumerable<Competitor> Competitors { get; set; } = null!;
        public ICollection<CoachGroup> CoachGroups { get; set; } = null!;
        public ICollection<GroupExercise> GroupExercises { get; set; } = null!;
        public virtual SportClub.Api.Domain.Entity.File File { get; set; } = null!;
    }
}
