using iShopMainVer2.Models.Entity.Order;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.Order;

public class OrderConfiguration : BaseEntityConfiguration<OrderEntity>
{

    public override void ConfigEntity(EntityTypeBuilder<OrderEntity> builder)
    {
        builder.ToTable("order");
        builder.HasOne()
    }
}
