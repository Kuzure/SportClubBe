namespace SportClub.Domain.Entity
{
    public class Competitor : BaseEntity<Guid>
    {
        public DateTime MedicalExaminationExpiryDate { get; set; }
        public bool IsPaid { get; set; }
        public Guid IdentityId { get; set; }
        public virtual Identity Identity { get; set; } = null!;
        public Guid? GroupId { get; set; }
        public virtual Group Group { get; set; } = null!;
    }
}
