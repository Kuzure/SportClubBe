using SportClub.Domain.Enum;

namespace SportClub.Domain.Entity
{
    public class Identity : BaseEntity<Guid>
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public Gender Gender { get; set; }
        public Degree? Degree { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual Coach Coach { get; set; } = null!;
        public virtual Competitor Competitor { get; set; } = null!;
    }
}
