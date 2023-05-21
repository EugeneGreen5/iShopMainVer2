using iShopMainVer2.Models.Entity.Characteristic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.Characteristic;

public class CharacteristicConfiguration : BaseEntityConfiguration<CharacteristicEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<CharacteristicEntity> builder)
    {
        builder.ToTable("characteristic");         
    }
}
