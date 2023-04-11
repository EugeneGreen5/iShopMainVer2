using iShopMain.Data;
using iShopMain.Helpers;
using iShopMain.Models.Dto;
using iShopMain.Models.Dto.RequestDto;
using iShopMain.Models.Entity.UserInfo;
using iShopMain.Repositories.User;
using iShopMain.Services;
using Microsoft.AspNetCore.Mvc;

namespace iShopMain.Controllers
{
    [ApiController]
    [Route("/api/users")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IService _service;


        public UserController(ILogger<UserController> logger
            , IService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost("registration")]
        public async Task<ActionResult<UserRequestDto>> CreateUserAsync(RegistrationUserDto newUser)    
        {
            var request = await _service.InitializeAsync(newUser);
            return request;
        }

        [HttpPost("authorization")]
        public async Task<ActionResult<UserRequestDto>> CheckUserAsync(AuthorizationUserDto newUser)
        {
            return await _service.isAuthorizationAsync(newUser);
        }
    }
}
