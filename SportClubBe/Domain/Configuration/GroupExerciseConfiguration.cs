using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportClubBe.Entity;

namespace SportClubBe.Configuration
{
    public class GroupExerciseConfiguration : BaseEntityConfiguration<Guid, GroupExercise>
    {
        public GroupExerciseConfiguration() : base("GroupExercise")
        {
        }
        public override void Configure(EntityTypeBuilder<GroupExercise> builder)
        {
            builder.HasOne(x => x.Group).WithMany(x => x.GroupExercises).HasForeignKey(x => x.GroupId);
            builder.HasOne(x => x.Exercise).WithMany(x => x.GroupExercises).HasForeignKey(x => x.ExercisesId);
            base.Configure(builder);
        }
    }
}
