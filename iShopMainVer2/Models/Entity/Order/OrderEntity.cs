using iShopMainVer2.Models.Entity.UserInfo;

namespace iShopMainVer2.Models.Entity.Order;

public class OrderEntity : BaseEntity
{
    public double OrderAmount { get; set; }
    public DateOnly CreatedDate { get; init; }
    public Guid UserId { get; set; }
    public Guid AddressId { get; set; }
    public virtual UserEntity User { get; set; }
    public virtual AddressEntity Address { get; set; }
    public virtual ICollection<ElementOrderEntity> ElementsOrders { get; set; } = new List<ElementOrderEntity>();
}
