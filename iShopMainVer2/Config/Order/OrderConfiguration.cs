using iShopMainVer2.Models.Entity.Order;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.Order;

public class OrderConfiguration : BaseEntityConfiguration<OrderEntity>
{

    public override void ConfigEntity(EntityTypeBuilder<OrderEntity> builder)
    {
        builder.ToTable("order");

        builder.HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId);

        builder.HasMany(x => x.ElementsOrders)
            .WithOne(x => x.Order)
            .HasForeignKey(x => x.OrderId);

        builder.HasOne(x => x.Address)
            .WithOne()
            .HasPrincipalKey<OrderEntity>(nameof(OrderEntity.AddressId));
    }
}
