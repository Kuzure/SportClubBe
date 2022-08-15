using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SportClub.Persistance.Configuration
{
    public class FileConfiguration : BaseEntityConfiguration<Guid, SportClub.Domain.Entity.File>
    {
        public FileConfiguration() : base("File")
        {
        }

        public override void Configure(EntityTypeBuilder<SportClub.Domain.Entity.File> builder)
        {
            builder.HasOne(x => x.Group).WithOne(x => x.File).HasForeignKey<SportClub.Domain.Entity.File>(x => x.GroupId);
            base.Configure(builder);
        }
    }
}
