    using iShopMainVer2.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config;

public abstract class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
    where TEntity : BaseEntity
{ 
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(p => p.Id).ValueGeneratedOnAdd();

        ConfigEntity(builder);
    }

    public abstract void ConfigEntity(EntityTypeBuilder<TEntity> builder);
}
