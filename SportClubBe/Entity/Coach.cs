namespace SportClubBe.Entity
{
    public class Coach
    {
        public Guid Id { get; set; }
        public int CoachClass { get; set; }
        public Guid IdentityId { get; set; }
        public virtual Identity Identity { get; set; }
        public ICollection<CoachGroup> CoachGroups { get; set; }
    }
}
