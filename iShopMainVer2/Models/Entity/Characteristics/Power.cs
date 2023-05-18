namespace iShopMainVer2.Models.Entity.Characteristics
{
    public class Power : CharacteristicsAbstract
    {
        public string TypeOfChargingConnector { get; set; }
        public bool IsWirelessCharging { get; set; }
        public bool IsFastCharging { get; set; }
        public string WorkingHours { get; set; }
        public string BatteryCapacity { get; set; }
        public bool IsPowerUnit { get; set; }
    }
}
