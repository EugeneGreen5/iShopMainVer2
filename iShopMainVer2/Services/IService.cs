using iShopMain.Models.Dto;
using iShopMain.Models.Dto.RequestDto;

namespace iShopMain.Services
{
    public interface IService
    {
        Task<UserRequestDto> InitializeAsync(IDto service);
        Task<UserRequestDto> isAuthorizationAsync(IDto userDto);
    }
}
