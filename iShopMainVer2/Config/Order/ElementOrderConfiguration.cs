using iShopMainVer2.Models.Entity.Order;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.Order;

public class ElementOrderConfiguration : BaseEntityConfiguration<ElementOrderEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<ElementOrderEntity> builder)
    {
        builder.ToTable("element_order");

        builder.HasKey(x => new { x.ProductId, x.OrderId });
        builder.HasOne(x => x.Product)
            .WithMany(x => x.ElementOrders)
            .HasForeignKey(x => x.ProductId);

        builder.HasOne(x => x.Order)
            .WithMany(x => x.ElementsOrders)
            .HasForeignKey(x => x.OrderId);
    }
}
