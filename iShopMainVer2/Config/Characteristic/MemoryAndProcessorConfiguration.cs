using iShopMainVer2.Models.Entity.Characteristic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iShopMainVer2.Config.Characteristic;

public class MemoryAndProcessorConfiguration : BaseEntityConfiguration<MemoryAndProcessorEntity>
{
    public override void ConfigEntity(EntityTypeBuilder<MemoryAndProcessorEntity> builder)
    {
        builder.ToTable("memory_and_processor");
    }
}
