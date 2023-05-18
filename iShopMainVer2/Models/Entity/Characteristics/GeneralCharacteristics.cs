using iShopMainVer2.Models.Entity.Characteristics;

namespace iShopMainVer2.Models.Entity.Сharacteristic
{
    public class GeneralCharacteristics : CharacteristicsAbstract
    {
        public string Country { get; set; }
        public int ProductServiceLife { get; set; }
        public int WarrantyPeriod { get; set; }
        public string OperationSystem { get; set; }
        public string Weight { get; set; }
        public string Size { get; set; }
    }
}
