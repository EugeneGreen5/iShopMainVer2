using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iShopMain.Models.Entity.UserInfo
{
    public class AppUser
    {
        [Key]
        public Guid Id { get; set; }
        public virtual Guid AccountId { get; set; }
        public virtual Guid InformationId { get; set; }
        public virtual int RoleId { get; set; }

        public AppUser()
        {
            Id = Guid.NewGuid();
        }
    }
}
