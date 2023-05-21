using iShopMainVer2.Models.Dto;
using iShopMainVer2.Models.Dto.RequestDto;

namespace iShopMainVer2.Services
{
    public interface IService
    {
        Task<UserRequestDto> InitializeAsync(RegistrationUserDto userDto);
        Task<UserRequestDto> isAuthorizationAsync(AuthorizationUserDto userDto);
    }
}
