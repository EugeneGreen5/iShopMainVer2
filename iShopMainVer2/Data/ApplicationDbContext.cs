using iShopMain.Helpers;
using iShopMain.Models.Entity.UserInfo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace iShopMain.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<AppUser> users { get; set; }
        public DbSet<Account> accounts { get; set; }
        public DbSet<Information> informations { get; set; }
        public DbSet<Role> roles { get; set; }
        public ApplicationDbContext(DbContextOptions options) 
            : base(options)
        { 

            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region add fake data
            var role1 = new Role { NameRole = "user" };
            var role2 = new Role { NameRole = "admin" };
            modelBuilder.Entity<Role>().HasData(role1, role2);
     
            var account1 = new Account { Login = "alesha@mail.ru", Password = GenerateSHA512.Create("123") };
            var account2 = new Account { Login = "petr@gmail.com", Password = GenerateSHA512.Create("321") };
            modelBuilder.Entity<Account>().HasData(account1, account2);

            var information1 = new Information { Email = "alesha@mail.ru", Name = "Алексей", Surname = "Иванов", Patronymic = "Васильевич", PhoneNumber = "+32112345698" };
            var information2 = new Information { Email = "petr@gmail.com", Name = "Petr", Surname = "Vasiliev", Patronymic = "Sergeevich", PhoneNumber = "+12345689093" };
            modelBuilder.Entity<Information>().HasData(information1, information2);

            var user1 = new AppUser { AccountId = account1.Id, InformationId = information1.Id, RoleId = role1.Id };
            var user2 = new AppUser { AccountId = account2.Id, InformationId = information2.Id, RoleId = role2.Id };

            modelBuilder.Entity<AppUser>().HasData(user1, user2);

            #endregion
        }
    }
}
