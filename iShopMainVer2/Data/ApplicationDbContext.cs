using iShopMainVer2.Helpers;
using iShopMainVer2.Models.Entity.UserInfo;
using iShopMainVer2.Models.Entity.Characteristic;
using iShopMainVer2.Models.Entity.Order;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace iShopMainVer2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<AddressEntity> Address { get; set; }
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
            Database.EnsureCreated();

        }
        /// <summary>
        /// Connect all config to db and init fake data
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);


            #region add fake data
            var account1 = new AccountEntity { Login = "alesha@mail.ru", Password = GenerateSHA512.Create("123") };
            var account2 = new AccountEntity { Login = "petr@gmail.com", Password = GenerateSHA512.Create("321") };
            modelBuilder.Entity<AccountEntity>().HasData(account1, account2);

            var information1 = new InformationEntity { Email = "alesha@mail.ru", Name = "Алексей", Surname = "Иванов", Patronymic = "Васильевич", PhoneNumber = "+32112345698" };
            var information2 = new InformationEntity { Email = "petr@gmail.com", Name = "Petr", Surname = "Vasiliev", Patronymic = "Sergeevich", PhoneNumber = "+12345689093" };
            modelBuilder.Entity<InformationEntity>().HasData(information1, information2);

            var user1 = new UserEntity ( account1.Id, information1.Id, "user" );
            var user2 = new UserEntity ( account2.Id, information2.Id, "admin");

            modelBuilder.Entity<UserEntity>().HasData(user1, user2);
            #endregion
        }
    }
}
