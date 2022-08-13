using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportClubBe.Configuration;
using SportClubBe.Entity;

namespace SportClub.Api.Domain.Configuration
{
    public class IdentityConfiguration : BaseEntityConfiguration<Guid, Role>
    {
        public IdentityConfiguration() : base("Role")
        {

        }
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);
        }
    }
}
