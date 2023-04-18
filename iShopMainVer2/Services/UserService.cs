using iShopMain.Helpers;
using iShopMain.Models.Dto;
using iShopMain.Models.Dto.RequestDto;
using iShopMain.Models.Entity.UserInfo;
using iShopMain.Repositories.User;
using iShopMainVer2.Repositories.User;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace iShopMain.Services
{
    public class UserService : IService
    {
        private readonly IRepository<AppUser> _dbUser;
        private readonly IRepository<Account> _dbAccount;
        private readonly IRepository<Information> _dbInformation;
        private readonly IRoleRepository _dbRole;

        public UserService(IRepository<AppUser> dbUser,
            IRepository<Account> dbAccount,
            IRepository<Information> dbInformation,
            IRoleRepository dbRole)
        {
            _dbUser = dbUser;
            _dbAccount = dbAccount;
            _dbInformation = dbInformation;
            _dbRole = dbRole;
        }

        public async Task<UserRequestDto> InitializeAsync(IDto newUserDto)
        {
            var newUser = (RegistrationUserDto)newUserDto;
            var accounts = await _dbAccount.GetListAsync();

            foreach (var acc in accounts)
            {
                if (acc.Login.Equals(newUser.Email))
                {
                    return new UserRequestDto()
                    {
                        CodeRequest = 400,
                        MessageRequest = "Пользователь с данным логином уже зарегистрирован."
                    };

                }
            }

            var user = new AppUser();

            var account = new Account();
            user.AccountId = account.Id;
            account.Login = newUser.Email;
            account.Password = GenerateSHA512.Create(newUser.Password);

            var role = await _dbRole.GetRoleAsync("user");
            user.RoleId = role.Id;

            var information = new Information();
            user.InformationId = information.Id;
            information.Email = newUser.Email;
            information.Name = newUser.Name;

            await _dbUser.CreateAsync(user);
            await _dbInformation.CreateAsync(information);
            await _dbAccount.CreateAsync(account);


            return new UserRequestDto()
            {
                CodeRequest = 200,
                MessageRequest = $"{user.Id}"
            };
        }

        public async Task<UserRequestDto> isAuthorizationAsync(IDto userDto)
        {
            var user = (AuthorizationUserDto)userDto;
            var accounts = await _dbAccount.GetListAsync();

            foreach (var account in accounts)
            {
                if (account.Login.Equals(user.Login)) {
                    if (account.Password.Equals(GenerateSHA512.Create(user.Password))){
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

            return new UserRequestDto()
            {
                CodeRequest = 419,
                MessageRequest = "Пользователя с данным логином не существует."
            };
        }


    }
}
