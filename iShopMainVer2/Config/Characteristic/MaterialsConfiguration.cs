using iShopMainVer2.Models.Entity.Characteristic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.Characteristic;

public class MaterialsConfiguration : BaseEntityConfiguration<MaterialsEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<MaterialsEntity> builder)
    {
        builder.ToTable("materials");
    }
}
