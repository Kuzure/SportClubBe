namespace SportClub.Domain.Entity
{
    public sealed class Group : BaseEntity<Guid>
    {
        public string? Name { get; set; } = null!;
        public IEnumerable<Competitor> Competitors { get; set; } = null!;
        public ICollection<CoachGroup> CoachGroups { get; set; } = null!;
        public ICollection<GroupExercise> GroupExercises { get; set; } = null!;
        public File File { get; set; } = null!;
    }
}
