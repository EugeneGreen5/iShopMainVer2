using iShopMainVer2.Models.Entity.Order;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.Order;

public class ElementOrderConfiguration : BaseEntityConfiguration<ElementOrderEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<ElementOrderEntity> builder)
    {
        builder.ToTable("element_order");

        builder.HasKey(x => new { x.ProductID, x.OrderId });
    }
}
