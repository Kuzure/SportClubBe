using SportClub.Domain.Entity;

namespace SportClub.Persistance.Configuration
{
    public class CoachConfiguration : BaseEntityConfiguration<Guid, Coach>
    {
        public CoachConfiguration() : base("Coach")
        {

        }
    }
}
