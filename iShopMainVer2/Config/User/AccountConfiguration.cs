using iShopMain.Models.Entity.UserInfo;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.User;

public class AccountConfiguration : BaseEntityConfiguration<AccountEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<AccountEntity> builder)
    {
        throw new NotImplementedException();
    }
}
