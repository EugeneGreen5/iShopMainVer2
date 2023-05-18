using System.ComponentModel.DataAnnotations;

namespace iShopMain.Models.Entity.UserInfo;

public class AppUser
{
    [Key]
    public Guid Id { get; set; }
    public Guid AccountId { get; set; }
    public Guid InformationId { get; set; }
    public Guid RoleId { get; set; }

    public AppUser()
    {
        Id = Guid.NewGuid();
    }

    public AppUser(
        Guid asccountId
        , Guid informationId
        , Guid roleId)
    {
        Id = Guid.NewGuid();
        AccountId = asccountId;
        InformationId = informationId;
        RoleId = roleId;
    }
}
