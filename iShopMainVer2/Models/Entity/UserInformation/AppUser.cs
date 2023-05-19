using iShopMainVer2.Models.Entity;
using System.ComponentModel.DataAnnotations;

namespace iShopMain.Models.Entity.UserInfo;

public class AppUser : BaseEntity
{
    public Guid AccountId { get; set; }
    public Guid InformationId { get; set; }
    public string Role { get; init; }

    public AppUser(
        Guid asccountId
        , Guid informationId
        )
    {
        Id = Guid.NewGuid();
        AccountId = asccountId;
        InformationId = informationId;
        Role = "user";
    }
}
