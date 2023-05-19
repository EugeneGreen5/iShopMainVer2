using iShopMainVer2.Models.Entity.Order;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.Order;

public class AddressConfiguration : BaseEntityConfiguration<AddressEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<AddressEntity> builder)
    {
        throw new NotImplementedException();
    }
}
