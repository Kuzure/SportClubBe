namespace SportClub.Domain.Entity
{
    public class User : BaseEntity<Guid>
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public Guid RoleId { get; set; }
        public virtual Role Role { get; set; } = null!;
        public virtual Identity Identity { get; set; } = null!;
    }
}
