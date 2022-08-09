using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportClubBe.Entity;

namespace SportClubBe.Configuration
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
