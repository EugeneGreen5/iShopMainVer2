using iShopMain.Helpers;
using iShopMain.Models.Entity.UserInfo;
using iShopMainVer2.Models.Entity;
using iShopMainVer2.Models.Entity.CharacteristicEntity;
using iShopMainVer2.Models.Entity.Сharacteristic;
using iShopMainVer2.Models.Entity.СharacteristicInformation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection.PortableExecutable;

namespace iShopMain.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<AccountEntity> Accounts { get; set; }
        public DbSet<InformationEntity> Informations { get; set; }
        public DbSet<CameraEntity> Cameras { get; set; }
        public DbSet<CharacteristicEntity> Сharacteristics { get; set; } 
        public DbSet<GeneralCharacteristicEntity> GeneralCharacteristics { get; set; }
        public DbSet<MaterialsEntity> MaterialsEntity { get; set; }
        public DbSet<MemoryAndProcessorEntity> MemoryAndProcessors { get; set; }
        public DbSet<PowerEntity> Powers { get; set; }
        public DbSet<ScreenEntity> Screens { get; set; }
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
     
            var account1 = new AccountEntity { Login = "alesha@mail.ru", Password = GenerateSHA512.Create("123") };
            var account2 = new AccountEntity { Login = "petr@gmail.com", Password = GenerateSHA512.Create("321") };
            modelBuilder.Entity<AccountEntity>().HasData(account1, account2);

            var information1 = new InformationEntity { Email = "alesha@mail.ru", Name = "Алексей", Surname = "Иванов", Patronymic = "Васильевич", PhoneNumber = "+32112345698" };
            var information2 = new InformationEntity { Email = "petr@gmail.com", Name = "Petr", Surname = "Vasiliev", Patronymic = "Sergeevich", PhoneNumber = "+12345689093" };
            modelBuilder.Entity<InformationEntity>().HasData(information1, information2);

            var user1 = new UserEntity { AccountId = account1.Id, InformationId = information1.Id, RoleId = role1.Id };
            var user2 = new UserEntity { AccountId = account2.Id, InformationId = information2.Id, RoleId = role2.Id };

            modelBuilder.Entity<UserEntity>().HasData(user1, user2);

            #endregion
        }
    }
}
