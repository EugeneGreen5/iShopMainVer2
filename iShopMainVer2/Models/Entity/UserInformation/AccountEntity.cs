using iShopMainVer2.Models.Entity;

namespace iShopMain.Models.Entity.UserInfo
{
    public class AccountEntity : BaseEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
