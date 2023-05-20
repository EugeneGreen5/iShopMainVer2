using iShopMainVer2.Models.Entity.Characteristic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.Characteristic;

public class PowerConfiguration : BaseEntityConfiguration<PowerEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<PowerEntity> builder)
    {
        builder.ToTable("power");
    }
}
