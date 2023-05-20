using iShopMain.Models.Entity.UserInfo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.User;

public class UserConfiguration : BaseEntityConfiguration<UserEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<UserEntity> builder)
    {
        builder.ToTable("user");
    }
}
