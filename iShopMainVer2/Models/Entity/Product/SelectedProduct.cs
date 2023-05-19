namespace iShopMainVer2.Models.Entity.Product;

public class SelectedProduct : BaseEntity
{
    public Guid ProductId { get; set; }
    public Guid UserId { get; set; }
}
