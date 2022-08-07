namespace SportClubBe.Entity
{
    public class Role : BaseEntity<Guid>
    {
        public string Name { get; set; } = null!;
        public virtual IEnumerable<User> Users { get; set; } = null!;
    }
}
