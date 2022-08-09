using SportClubBe.Entity;

namespace SportClubBe.Configuration
{
    public class GroupConfiguration : BaseEntityConfiguration<Guid, Group>
    {
        public GroupConfiguration() : base("Group")
        {
        }
    }
}
