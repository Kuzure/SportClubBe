using SportClub.Domain.Entity;

namespace SportClub.Persistance.Configuration
{
    public class GroupConfiguration : BaseEntityConfiguration<Guid, Group>
    {
        public GroupConfiguration() : base("Group")
        {
        }
    }
}
