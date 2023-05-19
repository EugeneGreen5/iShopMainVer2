using iShopMainVer2.Models.Entity.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.Product;

public class SelectedProductConfiguration : BaseEntityConfiguration<SelectedProductEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<SelectedProductEntity> builder)
    {
        throw new NotImplementedException();
    }
}
