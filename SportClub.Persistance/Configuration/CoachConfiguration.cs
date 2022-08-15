using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportClub.Domain.Entity;

namespace SportClub.Persistance.Configuration
{
    public class CoachConfiguration : BaseEntityConfiguration<Guid, Coach>
    {
        public CoachConfiguration() : base("Coach")
        {

        }
        public override void Configure(EntityTypeBuilder<Coach> builder)
        {
            base.Configure(builder);
        }
    }
}
