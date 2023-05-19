using iShopMain.Helpers;
using iShopMain.Models.Entity.UserInfo;
using iShopMainVer2.Models.Entity.Characteristics;
using iShopMainVer2.Models.Entity.Сharacteristic;
using iShopMainVer2.Models.Entity.СharacteristicInformation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace iShopMain.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Characteristics> Сharacteristics { get; set; } 
        public DbSet<GeneralCharacteristics> GeneralCharacteristics { get; set; }
        public DbSet<Materials> Materials { get; set; }
        public DbSet<MemoryAndProcessor> MemoryAndProcessors { get; set; }
        public DbSet<Power> Powers { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public ApplicationDbContext(DbContextOptions options, ModelBuilder modelBuilder) 
            : base(options)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            //Database.EnsureCreated();
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
