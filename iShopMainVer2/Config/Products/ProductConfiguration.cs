using iShopMainVer2.Models.Entity.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.Products;

public class ProductConfiguration : BaseEntityConfiguration<ProductEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<ProductEntity> builder)
    {
        builder.ToTable("product");
    }
}
