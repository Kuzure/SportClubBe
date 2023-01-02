using SportClub.Domain.Entity;

namespace SportClub.Persistance.Configuration
{
    public class RoleConfiguration : BaseEntityConfiguration<Guid, Role>
    {
        public RoleConfiguration() : base("Role")
        {

        }
    }
}
