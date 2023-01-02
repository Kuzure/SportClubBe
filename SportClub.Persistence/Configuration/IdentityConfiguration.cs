using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportClub.Domain.Entity;

namespace SportClub.Persistance.Configuration
{
    public class IdentityConfiguration : BaseEntityConfiguration<Guid, Identity>
    {
        public IdentityConfiguration() : base("Identity")
        {

        }
        public override void Configure(EntityTypeBuilder<Identity> builder)
        {
            builder.HasOne(x => x.Competitor).WithOne(x => x.Identity).HasForeignKey<Competitor>(x => x.IdentityId);
            base.Configure(builder);
        }

    }
}
