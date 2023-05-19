﻿namespace iShopMainVer2.Models.Entity.Characteristic
{
    public class PowerEntity : BaseEntity
    {
        public string TypeOfChargingConnector { get; set; }
        public bool IsWirelessCharging { get; set; }
        public bool IsFastCharging { get; set; }
        public string WorkingHours { get; set; }
        public string BatteryCapacity { get; set; }
        public bool IsPowerUnit { get; set; }
    }
}
