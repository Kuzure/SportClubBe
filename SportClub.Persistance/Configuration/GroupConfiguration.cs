﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportClub.Domain.Entity;

namespace SportClub.Persistance.Configuration
{
    public class GroupConfiguration : BaseEntityConfiguration<Guid, Group>
    {
        public GroupConfiguration() : base("Group")
        {
        }
        public override void Configure(EntityTypeBuilder<Group> builder)
        {
            base.Configure(builder);
        }
    }
}
