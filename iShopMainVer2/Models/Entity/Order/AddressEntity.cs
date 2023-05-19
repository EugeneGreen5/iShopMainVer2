namespace iShopMainVer2.Models.Entity.Order;

public class AddressEntity : BaseEntity
{
    public int Index { get; set; }
    public string Region { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public int Housing { get; set; } // Корпусэ
    public int House { get; set; }
    public int Entrance { get; set; } // Подъезд
    public int Floor { get; set; } // Этаж
    public int Flat { get; set; } // Квартира
}
