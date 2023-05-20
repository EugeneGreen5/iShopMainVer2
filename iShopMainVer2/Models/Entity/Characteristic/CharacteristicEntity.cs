namespace iShopMainVer2.Models.Entity.Characteristic
{
    public class CharacteristicEntity : BaseEntity
    {
        public Guid GeneralCharacteristicsId { get; set; }
        public Guid MaterialId { get; set; }
        public Guid MemoryAndProcessorId { get; set; }
        public Guid ScreenId { get; set; }
        public Guid CameraId { get; set; }
        public Guid PowerId { get; set; }
        public virtual GeneralCharacteristicEntity GeneralCharacteristicEntity { get; set; }
        public virtual MaterialsEntity MaterialsEntity { get; set; }
        public virtual MemoryAndProcessorEntity MemoryAndProcessorEntity { get; set; }
        public virtual ScreenEntity ScreenEntity { get; set; }
        public virtual CameraEntity CameraEntity { get; set; }
        public virtual PowerEntity PowerEntity { get; set; }
        
    }
}
