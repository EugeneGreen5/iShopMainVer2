using iShopMain.Helpers;
using iShopMain.Models.Dto;
using iShopMain.Models.Dto.RequestDto;
using iShopMain.Models.Entity.UserInfo;
using iShopMain.Repositories.User;
using iShopMainVer2.Repositories.User;


namespace iShopMain.Services;

public class UserService : IService
{
    private readonly IRepository<UserEntity> _dbUser;
    private readonly IRepository<AccountEntity> _dbAccount;
    private readonly IRepository<InformationEntity> _dbInformation;
    private readonly IRoleRepository _dbRole;

    public UserService(IRepository<UserEntity> dbUser,
        IRepository<AccountEntity> dbAccount,
        IRepository<InformationEntity> dbInformation,
        IRoleRepository dbRole)
    {
        _dbUser = dbUser;
        _dbAccount = dbAccount;
        _dbInformation = dbInformation;
        _dbRole = dbRole;
    }

    public async Task<UserRequestDto> InitializeAsync(RegistrationUserDto newUserDto)
    {
        var isExists = await _dbAccount.AnyAsync(c=> c.Login.Equals(newUserDto.Email));
        if(isExists)
        {
            return new UserRequestDto()
            {
                CodeRequest = 400,
                MessageRequest = "Пользователь с данным логином уже зарегистрирован."
            };
        }

        var account = new AccountEntity() 
        {
            Login = newUserDto.Email,
            Password = GenerateSHA512.Create(newUserDto.Password)
        };
        var role = await _dbRole.GetRoleAsync("user");
        var information = newUserDto.GetInformationUser();
        var user = new UserEntity(account.Id, information.Id);

        await _dbInformation.CreateAsync(information);
        await _dbAccount.CreateAsync(account);
        await _dbUser.CreateAsync(user);

        return new UserRequestDto()
        {
            CodeRequest = 200,
            MessageRequest = $"{user.Id}"
        };
    }

    public async Task<UserRequestDto> isAuthorizationAsync(AuthorizationUserDto userDto)
    {
        var isExistsBy = await _dbAccount.AnyAsync(c => c.Login.Equals(userDto.Login));
        if (!isExistsBy)
        {
            return new UserRequestDto()
            {
                CodeRequest = 419,
                MessageRequest = "Пользователя с данным логином не существует."
            };
        }

        var passwordHash = GenerateSHA512.Create(userDto.Password);
        var isExistsByLoginAndPassword = await _dbAccount.AnyAsync(c => c.Login.Equals(userDto.Login)
                                                                        && c.Password.Equals(passwordHash));
        if(isExistsByLoginAndPassword) 
        {
            return new UserRequestDto()
            {
                CodeRequest = 200,
                MessageRequest = "Пользватель успешно авторизировался."
            };
        }

        return new UserRequestDto()
        {
            CodeRequest = 418,
            MessageRequest = "Введён неверный пароль."
        };
    }


}
