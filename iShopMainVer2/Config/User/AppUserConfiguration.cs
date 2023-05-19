using iShopMain.Models.Entity.UserInfo;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.User;

public class AppUserConfiguration : BaseEntityConfiguration<UserEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<UserEntity> builder)
    {
        throw new NotImplementedException();
    }
}
