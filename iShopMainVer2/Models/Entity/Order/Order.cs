namespace iShopMainVer2.Models.Entity.Order;

public class Order : BaseEntity
{
    public double OrderAmount { get; set; }
    public DateOnly CreatedDate { get; init; }
    public Guid UserId { get; set; }
    public Guid AddressId { get; set; }
    public virtual ICollection<ElementOrder> Elements { get; set; } = new List<ElementOrder>();
}
