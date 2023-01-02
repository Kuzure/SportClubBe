using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportClub.Domain.Entity;

namespace SportClub.Persistance.Configuration
{
    public class CoachGroupConfiguration : BaseEntityConfiguration<Guid, CoachGroup>
    {
        public CoachGroupConfiguration() : base("CoachGroup")
        {
        }
        public override void Configure(EntityTypeBuilder<CoachGroup> builder)
        {
            builder.HasOne(x => x.Group).WithMany(x => x.CoachGroups).HasForeignKey(x => x.GroupId);
            builder.HasOne(x => x.Coach).WithMany(x => x.CoachGroups).HasForeignKey(x => x.CoachId);
            base.Configure(builder);
        }
    }
}
