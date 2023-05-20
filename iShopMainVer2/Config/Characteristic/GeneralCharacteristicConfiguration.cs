﻿using iShopMainVer2.Models.Entity.Characteristic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.Characteristic;

public class GeneralCharacteristicConfiguration : BaseEntityConfiguration<GeneralCharacteristicEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<GeneralCharacteristicEntity> builder)
    {
        builder.ToTable("general_characteristic");
    }
}
