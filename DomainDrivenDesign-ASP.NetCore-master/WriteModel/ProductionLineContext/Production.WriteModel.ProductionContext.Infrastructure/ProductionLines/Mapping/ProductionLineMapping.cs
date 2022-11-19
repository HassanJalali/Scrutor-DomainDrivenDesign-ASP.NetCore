using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Production.Framework.Persistence;

namespace Production.WriteModel.ProductionContext.Infrastructure.ProductionLines.Mapping
{
    public class ProductionLineMapping : EntityMappingBase<Production.WriteModel.ProductionLine.Domain.ProductionLines.ProductionLine>
    {
        public override void Configure(EntityTypeBuilder<ProductionLine.Domain.ProductionLines.ProductionLine> builder)
        {
            Initial(builder);

            builder.Property(a => a.CostCenter)
                   .IsRequired();

            builder.Property(a => a.ProductionLineTitle)
                   .HasMaxLength(200)
                   .IsRequired();
        }
    }
}
