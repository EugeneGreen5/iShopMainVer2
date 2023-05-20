using iShopMainVer2.Models.Entity.Characteristic;
using iShopMainVer2.Models.Entity.Order;


namespace iShopMainVer2.Models.Entity.Products;

public class ProductEntity : BaseEntity
{
    public string Name { get; set; }
    public int CountOnWarehouse { get; set; }
    public Guid OverviewId { get; set; }
    public Guid CharacteristicId { get; set; }
    public virtual OverviewEntity Overview { get; set; }
    public virtual CharacteristicEntity Characteristic { get; set; }
    public virtual ICollection<ElementOrderEntity> ElementOrders { get; set; } = new List<ElementOrderEntity>();
    public virtual ICollection<SelectedProductEntity> SelectedProducts { get; set; } = new List<SelectedProductEntity>();
}
