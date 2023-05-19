using iShopMainVer2.Models.Entity;
using iShopMainVer2.Models.Entity.Order;
using iShopMainVer2.Models.Entity.Product;

namespace iShopMain.Models.Entity.UserInfo;

public class AppUser : BaseEntity
{
    public Guid AccountId { get; set; }
    public Guid InformationId { get; set; }
    public string Role { get; init; }
    public virtual ICollection<Order> OrderList { get; set; } = new List<Order>();
    public virtual ICollection<SelectedProduct> SelectedProducts { get; set; } = new List<SelectedProduct>();

    public AppUser(
        Guid accountId
        , Guid informationId
        )
    {
        Id = Guid.NewGuid();
        AccountId = accountId;
        InformationId = informationId;
        Role = "user";
    }
}
