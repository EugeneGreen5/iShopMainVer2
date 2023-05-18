using System.ComponentModel.DataAnnotations;

namespace iShopMainVer2.Models.Entity.Characteristics
{
    public abstract class CharacteristicsAbstract
    {
        [Key]
        public Guid Id { get; set; }
        public CharacteristicsAbstract()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
