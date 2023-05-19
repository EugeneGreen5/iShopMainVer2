namespace iShopMainVer2.Models.Entity.Order;

public class ElementOrderEntity : BaseEntity
{
    public Guid OrderId { get; set; }
    public Guid ProductID { get; set; }
    public int AmountProduct { get; set; }
}
