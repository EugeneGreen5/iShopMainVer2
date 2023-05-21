using iShopMainVer2.Helpers;
using iShopMainVer2.Models.Dto;
using iShopMainVer2.Models.Dto.RequestDto;
using iShopMainVer2.Models.Entity.UserInfo;
using iShopMainVer2.Repositories.User;



namespace iShopMainVer2.Services;

public class UserService : IService
{
    private readonly IRepository<UserEntity> _dbUser;
    private readonly IRepository<AccountEntity> _dbAccount;
    private readonly IRepository<InformationEntity> _dbInformation;

    public UserService(IRepository<UserEntity> dbUser,
        IRepository<AccountEntity> dbAccount,
        IRepository<InformationEntity> dbInformation)
    {
        _dbUser = dbUser;
        _dbAccount = dbAccount;
        _dbInformation = dbInformation;
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
        var information = newUserDto.GetInformationUser();
        var user = new UserEntity(account.Id, information.Id, "user");

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
