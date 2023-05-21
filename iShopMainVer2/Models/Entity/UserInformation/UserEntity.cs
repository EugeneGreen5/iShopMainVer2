using iShopMainVer2.Models.Entity;
using iShopMainVer2.Models.Entity.Order;
using iShopMainVer2.Models.Entity.Products;

namespace iShopMainVer2.Models.Entity.UserInfo;

public class UserEntity : BaseEntity
{
    public Guid AccountId { get; set; }
    public Guid InformationId { get; set; }
    public string Role { get; init; }
    public virtual AccountEntity Account { get; set; }
    public virtual InformationEntity Information { get; set; }
    public virtual ICollection<OrderEntity> OrderList { get; set; } = new List<OrderEntity>();
    public virtual ICollection<SelectedProductEntity> SelectedProducts { get; set; } = new List<SelectedProductEntity>();

    public UserEntity(
        Guid accountId,
        Guid informationId,
        String role
        )
    {
        Id = Guid.NewGuid();
        AccountId = accountId;
        InformationId = informationId;
        Role = role;
    }
}
