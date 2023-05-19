namespace iShopMainVer2.Models.Entity;

public abstract class BaseEntity
{
    public Guid Id { get; init; }
    public BaseEntity()
    {
        this.Id = Guid.NewGuid();
    }
}
