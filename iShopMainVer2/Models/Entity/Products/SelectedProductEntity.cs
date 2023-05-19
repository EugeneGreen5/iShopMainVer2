namespace iShopMainVer2.Models.Entity.Products;

public class SelectedProductEntity : BaseEntity
{
    public Guid ProductId { get; set; }
    public Guid UserId { get; set; }
}
