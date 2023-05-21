using iShopMainVer2.Models.Dto;
using iShopMainVer2.Models.Dto.RequestDto;
using iShopMainVer2.Services;
using Microsoft.AspNetCore.Mvc;

namespace iShopMainVer2.Controllers
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

        [HttpGet("accessdenied")]
        public ActionResult<UserRequestDto> UnauthorizedUserAsync()
        {
            var error = new UserRequestDto()
            {
                CodeRequest = 403,
                MessageRequest = "Access Denied"
            };
            return error;
        }
    }
}
