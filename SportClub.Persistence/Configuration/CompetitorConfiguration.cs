using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportClub.Domain.Entity;

namespace SportClub.Persistance.Configuration
{
    public class CompetitorConfiguration : BaseEntityConfiguration<Guid, Competitor>
    {
        public CompetitorConfiguration() : base("Competitor")
        {
        }
        public override void Configure(EntityTypeBuilder<Competitor> builder)
        {
            builder.HasOne(x => x.Group).WithMany(x => x.Competitors).HasForeignKey(x => x.GroupId);
            base.Configure(builder);
        }
    }
}
