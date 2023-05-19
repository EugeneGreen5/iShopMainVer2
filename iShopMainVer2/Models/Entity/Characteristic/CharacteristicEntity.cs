namespace iShopMainVer2.Models.Entity.Characteristic
{
    public class CharacteristicEntity : BaseEntity
    {
        public virtual Guid GeneralCharacteristicsId { get; set; }
        public virtual Guid MaterialId { get; set; }
        public virtual Guid MemoryAndProcessorId { get; set; }
        public virtual Guid ScreenId { get; set; }
        public virtual Guid CameraId { get; set; }
        public virtual Guid PowerId { get; set; }
    }
}
