using iShopMain.Models.Entity.UserInfo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.User;

public class InformationConfiguration : BaseEntityConfiguration<InformationEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<InformationEntity> builder)
    {
        builder.ToTable("information");

    }
}
