using iShopMainVer2.Models.Entity.Characteristic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.Characteristic;

public class CameraConfiguration : BaseEntityConfiguration<CameraEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<CameraEntity> builder)
    {
        builder.ToTable("camera");

    }
}
