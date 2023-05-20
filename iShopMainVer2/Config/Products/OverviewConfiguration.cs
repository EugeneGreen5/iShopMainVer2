using iShopMainVer2.Models.Entity.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.Product;

public class OverviewConfiguration : BaseEntityConfiguration<OverviewEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<OverviewEntity> builder)
    {
        builder.ToTable("overview");
    }
}
