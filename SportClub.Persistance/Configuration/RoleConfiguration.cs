using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportClub.Domain.Entity;

namespace SportClub.Persistance.Configuration
{
    public class RoleConfiguration : BaseEntityConfiguration<Guid, Role>
    {
        public RoleConfiguration() : base("Role")
        {

        }
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);
        }
    }
}
