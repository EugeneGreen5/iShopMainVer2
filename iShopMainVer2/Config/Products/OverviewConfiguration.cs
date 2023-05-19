using iShopMainVer2.Models.Entity.Product;
using iShopMainVer2.Models.Entity.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.Product;

public class OverviewConfiguration : BaseEntityConfiguration<OverviewEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<OverviewEntity> builder)
    {
        throw new NotImplementedException();
    }
}
