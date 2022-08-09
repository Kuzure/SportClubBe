namespace SportClub.Domain.Entity
{
    public class CoachGroup : BaseEntity<Guid>
    {
        public Guid GroupId { get; set; }
        public virtual Group Group { get; set; } = null!;
        public Guid CoachId { get; set; }
        public virtual Coach Coach { get; set; } = null!;
    }
}
