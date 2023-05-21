using iShopMainVer2.Models.Entity.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.Product;

public class SelectedProductConfiguration : BaseEntityConfiguration<SelectedProductEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<SelectedProductEntity> builder)
    {
        builder.ToTable("selected_product");
        builder.HasKey(x => new {x.ProductId, x.UserId});
        builder.HasOne(x => x.Product)
            .WithMany(x => x.SelectedProducts)
            .HasForeignKey(x => x.ProductId);
        builder.HasOne(x => x.User)
            .WithMany(x => x.SelectedProducts)
            .HasForeignKey(x => x.UserId);
    }
}
