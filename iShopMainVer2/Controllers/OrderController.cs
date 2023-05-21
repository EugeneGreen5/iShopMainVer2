using iShopMainVer2.Models.Entity.Order;
using Microsoft.AspNetCore.Mvc;

namespace iShopMainVer2.Controllers;

[ApiController]
[Route("/[controller]")]
public class OrderController : ControllerBase
{

    [HttpPost("create")]
    public async Task<IActionResult> CreateAddress(AddressEntity address)
    {

        
    }
}
