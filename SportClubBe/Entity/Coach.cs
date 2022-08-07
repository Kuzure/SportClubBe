namespace SportClubBe.Entity
{
    public class Coach : BaseEntity<Guid>
    {
        public int CoachClass { get; set; }
        public Guid IdentityId { get; set; }
        public virtual Identity Identity { get; set; } = null!;
        public ICollection<CoachGroup> CoachGroups { get; set; } = null!;
    }
}
