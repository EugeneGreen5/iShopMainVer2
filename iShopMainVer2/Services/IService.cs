using iShopMain.Models.Dto;
using iShopMain.Models.Dto.RequestDto;

namespace iShopMain.Services
{
    public interface IService
    {
        Task<UserRequestDto> InitializeAsync(RegistrationUserDto userDto);
        Task<UserRequestDto> isAuthorizationAsync(AuthorizationUserDto userDto);
    }
}
