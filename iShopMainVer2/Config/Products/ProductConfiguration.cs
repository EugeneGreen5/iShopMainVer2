using iShopMainVer2.Models.Entity.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.Products;

public class ProductConfiguration : BaseEntityConfiguration<ProductEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<ProductEntity> builder)
    {
        builder.ToTable("product");
        builder.HasMany(x => x.SelectedProducts)
            .WithOne(x => x.Product)
            .HasForeignKey(x => x.ProductId);
        builder.HasMany(x => x.ElementOrders)
            .WithOne(x => x.Product)
            .HasForeignKey(x => x.ProductId);
    }
}
