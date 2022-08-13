using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportClubBe.Configuration;

namespace SportClub.Api.Domain.Configuration
{
    public class FileConfiguration : BaseEntityConfiguration<Guid, SportClub.Api.Domain.Entity.File>
    {
        public FileConfiguration() : base("File")
        {
        }

        public override void Configure(EntityTypeBuilder<SportClub.Api.Domain.Entity.File> builder)
        {
            builder.HasOne(x => x.Group).WithOne(x => x.File).HasForeignKey<SportClub.Api.Domain.Entity.File>(x => x.GroupId);
            base.Configure(builder);
        }
    }
}
