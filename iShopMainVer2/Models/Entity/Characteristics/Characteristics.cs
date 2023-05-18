using iShopMainVer2.Models.Entity.Characteristics;

namespace iShopMainVer2.Models.Entity.СharacteristicInformation
{
    public class Characteristics : CharacteristicsAbstract
    {
        public virtual Guid GeneralCharacteristicsId { get; set; }
        public virtual Guid MaterialId { get; set; }
        public virtual Guid MemoryAndProcessorId { get; set; }
        public virtual Guid ScreenId { get; set; }
        public virtual Guid CameraId { get; set; }
        public virtual Guid PowerId { get; set; }
    }
}
