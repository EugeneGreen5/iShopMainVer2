using iShopMain.Models.Entity.UserInfo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.User;

public class UserConfiguration : BaseEntityConfiguration<UserEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<UserEntity> builder)
    {
        builder.ToTable("user");
        builder.HasMany(x => x.SelectedProducts)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId);

        builder.HasMany(x => x.OrderList)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId);

/*        builder.HasOne(x => x.Information)
            .WithOne()
            .HasForeignKey(x => x.);*/
    }
}
