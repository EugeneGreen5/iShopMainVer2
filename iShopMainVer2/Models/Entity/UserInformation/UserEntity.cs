using iShopMainVer2.Models.Entity;
using iShopMainVer2.Models.Entity.OrderEntity;
using iShopMainVer2.Models.Entity.Products;

namespace iShopMain.Models.Entity.UserInfo;

public class UserEntity : BaseEntity
{
    public Guid AccountId { get; set; }
    public Guid InformationId { get; set; }
    public string Role { get; init; }
    public virtual ICollection<OrderEntity> OrderList { get; set; } = new List<OrderEntity>();
    public virtual ICollection<SelectedProductEntity> SelectedProducts { get; set; } = new List<SelectedProductEntity>();

    public UserEntity(
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
