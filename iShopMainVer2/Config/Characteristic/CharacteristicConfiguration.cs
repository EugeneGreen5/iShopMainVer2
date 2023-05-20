using iShopMainVer2.Models.Entity.Characteristic;
using Microsoft.EntityFrameworkCore;

namespace iShopMainVer2.Config.Characteristic;

public class CharacteristicConfiguration : BaseEntityConfiguration<CharacteristicEntity>
{
    public override void ConfigEntity(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CharacteristicEntity> builder)
    {
        builder.ToTable("characteristic");
    }
}
