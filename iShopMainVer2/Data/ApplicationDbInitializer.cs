using iShopMain.Models.Entity.UserInfo;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace iShopMain.Data
{
    public static class ApplicationDbInitializer
    {

        public static void Initialize(ApplicationDbContext context) {
            AddModelRoles(context);
            AddModelInformation(context);
            AddModelAccount(context);
            AddModelUser(context);
            context.Database.Migrate();
        }

        #region add fake data
        private static void AddModelRoles(ApplicationDbContext context)
        {
            var newRoles = new Role[]
            {
                new Role { NameRole = "user"},
                new Role{ NameRole = "admin"}
            };
            context.Roles.AddRange(newRoles);
            context.SaveChanges();
        }

        private static void AddModelAccount(ApplicationDbContext context)
        {
            var newAccounts = new AccountEntity[]
            {
                new AccountEntity{Login = "alesha@mail.ru", Password = "123" },
                new AccountEntity{Login = "petr@gmail.com", Password = "321" }
            };
            context.Accounts.AddRange(newAccounts);
            context.SaveChanges();
        }

        private static void AddModelInformation(ApplicationDbContext context)
        {
            var newInformations = new InformationEntity[]
            {
                new InformationEntity { Email = "alesha@mail.ru", Name = "Алексей", Surname = "Иванов", Patronymic = "Васильевич", PhoneNumber = "+32112345698" },
                new InformationEntity { Email = "petr@gmail.com", Name = "Petr", Surname = "Vasiliev", Patronymic = "Sergeevich", PhoneNumber = "+12345689093"}
            };
            context.Informations.AddRange(newInformations);
            context.SaveChanges();
        }

        private static void AddModelUser(ApplicationDbContext context)
        {
            var newUsers = new AppUser[]
            {
                new AppUser{ AccountId = context.Accounts.First().Id,InformationId = context.Informations.First().Id, RoleId = context.Roles.First().Id},
                new AppUser{ AccountId = context.Accounts.Skip(1).First().Id, InformationId = context.Informations.Skip(1).First().Id, RoleId = context.Roles.Skip(1).First().Id }
            };

            context.Users.AddRange(newUsers);
            context.SaveChanges();
        }
        #endregion
    }
}
