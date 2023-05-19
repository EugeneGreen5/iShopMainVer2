using iShopMainVer2.Models.Entity.Order;


namespace iShopMainVer2.Models.Entity.Product;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public int CountOnWarehouse { get; set; }
    public Guid OverviewId { get; set; }
    public Guid CharacteristicId { get; set; }
    public virtual ICollection<ElementOrder> ElementOrders { get; set; } = new List<ElementOrder>();
    public virtual ICollection<SelectedProduct> SelectedProducts { get; set; } = new List<SelectedProduct>();
}
