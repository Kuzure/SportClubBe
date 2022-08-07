using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportClubBe.Entity;

namespace SportClubBe.Configuration
{
    public class UserConfiguration : BaseEntityConfiguration<Guid, User>
    {
        public UserConfiguration() : base("User")
        {

        }

        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasOne(x => x.Role).WithMany(x => x.Users).HasForeignKey(x => x.RoleId);
            builder.HasOne(x => x.Identity).WithOne(x => x.User).HasForeignKey<Identity>(x => x.UserId);
            base.Configure(builder);
        }
    }
}
