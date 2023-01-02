using SportClub.Domain.Entity;

namespace SportClub.Persistance.Configuration
{
    public class ExerciseConfiguration : BaseEntityConfiguration<Guid, Exercise>
    {
        public ExerciseConfiguration() : base("Exercise")
        {
        }
    }
}
