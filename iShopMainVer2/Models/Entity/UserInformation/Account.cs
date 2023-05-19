using iShopMainVer2.Models.Entity;
using System.ComponentModel.DataAnnotations;

namespace iShopMain.Models.Entity.UserInfo
{
    public class Account : BaseEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
