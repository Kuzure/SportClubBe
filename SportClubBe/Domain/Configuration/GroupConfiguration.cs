using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportClubBe.Entity;

namespace SportClubBe.Configuration
{
    public class GroupConfiguration : BaseEntityConfiguration<Guid, Group>
    {
        public GroupConfiguration() : base("Group")
        {
        }
        public override void Configure(EntityTypeBuilder<Group> builder)
        {
            base.Configure(builder);
        }
    }
}
