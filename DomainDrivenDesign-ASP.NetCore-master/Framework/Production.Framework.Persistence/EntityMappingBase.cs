using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Production.Framework.Core.Persistence;
using Production.Framework.Domain;
using System.Data;

namespace Production.Framework.Persistence
{
    public abstract class EntityMappingBase<TEntity> : IEntityTypeConfiguration<TEntity>, IEntityMapping where TEntity : EntityBase
    {
        public abstract void Configure(EntityTypeBuilder<TEntity> builder);

        protected void Initial(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnType(nameof(SqlDbType.UniqueIdentifier))
                .IsRequired()
                .ValueGeneratedNever();

            builder.HasKey(c => c.Id);

            builder.ToTable(typeof(TEntity).Name, typeof(TEntity).Namespace?.Split('.')[1]);

        }
    }
}
