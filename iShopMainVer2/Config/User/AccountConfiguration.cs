using iShopMainVer2.Helpers;
using iShopMainVer2.Models.Entity.UserInfo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace iShopMainVer2.Config.User;

public class AccountConfiguration : BaseEntityConfiguration<AccountEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<AccountEntity> builder)
    {
        builder.ToTable("account");
    }
}
