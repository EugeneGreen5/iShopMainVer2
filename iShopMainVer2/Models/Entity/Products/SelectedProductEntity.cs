﻿using iShopMain.Models.Entity.UserInfo;

namespace iShopMainVer2.Models.Entity.Products;

public class SelectedProductEntity : BaseEntity
{
    public Guid ProductId { get; set; }
    public Guid UserId { get; set; }
    public ProductEntity Product { get; set; }
    public UserEntity User { get; set; }
}
