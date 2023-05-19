namespace iShopMainVer2.Models.Entity.Characteristic
{
    public class GeneralCharacteristicEntity : BaseEntity
    {
        public string Country { get; set; }
        public int ProductServiceLife { get; set; }
        public int WarrantyPeriod { get; set; }
        public string OperationSystem { get; set; }
        public string Weight { get; set; }
        public string Size { get; set; }
    }
}
