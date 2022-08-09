using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportClubBe.Entity;

namespace SportClubBe.Configuration
{
    public abstract class BaseEntityConfiguration<TKey, TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity<TKey> where TKey : struct
    {
        private readonly string tableName;

        public BaseEntityConfiguration(string tableName)
        {
            this.tableName = tableName;
        }
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.ToTable(tableName);
            builder.HasKey(x => x.Id);

            builder.HasQueryFilter(x => x.IsActive);
        }
    }
}
