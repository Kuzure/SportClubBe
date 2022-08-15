using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportClub.Domain.Entity;

namespace SportClub.Persistance.Configuration
{
    public class ExerciseConfiguration : BaseEntityConfiguration<Guid, Exercise>
    {
        public ExerciseConfiguration() : base("Exercise")
        {
        }
        public override void Configure(EntityTypeBuilder<Exercise> builder)
        {
            base.Configure(builder);
        }
    }
}
