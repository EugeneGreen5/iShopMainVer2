using iShopMainVer2.Models.Entity.Characteristic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.Characteristic;

public class ScreenConfiguration : BaseEntityConfiguration<ScreenEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<ScreenEntity> builder)
    {
        builder.ToTable("screen");
    }
}
