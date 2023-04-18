using System.ComponentModel.DataAnnotations;

namespace iShopMain.Models.Entity.UserInfo
{
    public class Role
    {
        [Key]
        public Guid Id { get; set; }
        public string NameRole { get; set; }
        public Role()
        {
            Id = Guid.NewGuid();
        }
    }
}
