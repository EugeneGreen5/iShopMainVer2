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
            context.roles.AddRange(newRoles);
            context.SaveChanges();
        }

        private static void AddModelAccount(ApplicationDbContext context)
        {
            var newAccounts = new Account[]
            {
                new Account{Login = "alesha@mail.ru", Password = "123" },
                new Account{Login = "petr@gmail.com", Password = "321" }
            };
            context.accounts.AddRange(newAccounts);
            context.SaveChanges();
        }

        private static void AddModelInformation(ApplicationDbContext context)
        {
            var newInformations = new Information[]
            {
                new Information { Email = "alesha@mail.ru", Name = "Алексей", Surname = "Иванов", Patronymic = "Васильевич", PhoneNumber = "+32112345698" },
                new Information { Email = "petr@gmail.com", Name = "Petr", Surname = "Vasiliev", Patronymic = "Sergeevich", PhoneNumber = "+12345689093"}
            };
            context.informations.AddRange(newInformations);
            context.SaveChanges();
        }

        private static void AddModelUser(ApplicationDbContext context)
        {
            var newUsers = new AppUser[]
            {
                new AppUser{ AccountId = context.accounts.First().Id,InformationId = context.informations.First().Id, RoleId = context.roles.First().Id},
                new AppUser{ AccountId = context.accounts.Skip(1).First().Id, InformationId = context.informations.Skip(1).First().Id, RoleId = context.roles.Skip(1).First().Id }
            };

            context.users.AddRange(newUsers);
            context.SaveChanges();
        }
        #endregion
    }
}
