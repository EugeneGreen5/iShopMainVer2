using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iShopMainVer2.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Сharacteristics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GeneralCharacteristicsId = table.Column<Guid>(type: "uuid", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uuid", nullable: false),
                    MemoryAndProcessorId = table.Column<Guid>(type: "uuid", nullable: false),
                    ScreenId = table.Column<Guid>(type: "uuid", nullable: false),
                    CameraId = table.Column<Guid>(type: "uuid", nullable: false),
                    PowerId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Сharacteristics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Login = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cameras",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MainCamera = table.Column<string>(type: "text", nullable: false),
                    UltraWideAngleCamera = table.Column<string>(type: "text", nullable: false),
                    ZoomCamera = table.Column<string>(type: "text", nullable: false),
                    MaximumResolutionVideo = table.Column<string>(type: "text", nullable: false),
                    MaximumFrequencyVideo = table.Column<string>(type: "text", nullable: false),
                    WebCamera = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cameras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralCharacteristicsEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    ProductServiceLife = table.Column<int>(type: "integer", nullable: false),
                    WarrantyPeriod = table.Column<int>(type: "integer", nullable: false),
                    OperationSystem = table.Column<string>(type: "text", nullable: false),
                    Weight = table.Column<string>(type: "text", nullable: false),
                    Size = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralCharacteristics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Informations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Patronymic = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    DateOfRegistration = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialsEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MaterialBody = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemoryAndProcessors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Processor = table.Column<string>(type: "text", nullable: false),
                    NumberOfProcessorCores = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemoryAndProcessors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Powers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TypeOfChargingConnector = table.Column<string>(type: "text", nullable: false),
                    IsWirelessCharging = table.Column<bool>(type: "boolean", nullable: false),
                    IsFastCharging = table.Column<bool>(type: "boolean", nullable: false),
                    WorkingHours = table.Column<string>(type: "text", nullable: false),
                    BatteryCapacity = table.Column<string>(type: "text", nullable: false),
                    IsPowerUnit = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Powers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NameRole = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Screens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DiagonalScreen = table.Column<int>(type: "integer", nullable: false),
                    TypeScreen = table.Column<string>(type: "text", nullable: false),
                    ResolutionScreen = table.Column<string>(type: "text", nullable: false),
                    FrequencyScreen = table.Column<int>(type: "integer", nullable: false),
                    IsTouchScreen = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AccountId = table.Column<Guid>(type: "uuid", nullable: false),
                    InformationId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("42320546-2688-48a1-8481-913a693aaa0a"), "petr@gmail.com", "3043AA4A83B0934982956A90828140CB834869135B5F294938865DE12E036DE440A330E1E8529BEC15DDD59F18D1161A97BFEC110D2622680F2C714A737D7061" },
                    { new Guid("606d29c4-7610-48ee-871e-d1308167f893"), "alesha@mail.ru", "3C9909AFEC25354D551DAE21590BB26E38D53F2173B8D3DC3EEE4C047E7AB1C1EB8B85103E3BE7BA613B31BB5C9C36214DC9F14A42FD7A2FDB84856BCA5C44C2" }
                });

            migrationBuilder.InsertData(
                table: "Informations",
                columns: new[] { "Id", "DateOfRegistration", "Email", "Name", "Patronymic", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { new Guid("76a19559-5cbf-4441-b354-146a50ad2d2d"), new DateOnly(2023, 5, 18), "alesha@mail.ru", "Алексей", "Васильевич", "+32112345698", "Иванов" },
                    { new Guid("7b9bab6e-fd30-411a-b082-6a5dceec665a"), new DateOnly(2023, 5, 18), "petr@gmail.com", "Petr", "Sergeevich", "+12345689093", "Vasiliev" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "NameRole" },
                values: new object[,]
                {
                    { new Guid("1a0a3dfa-6f09-4fa4-820b-22d75ab6ac0f"), "user" },
                    { new Guid("34137b96-9b27-4d0e-b11c-ea7946a620ff"), "admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccountId", "InformationId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("1bcf071d-c7f1-43e3-9150-a2976a237cab"), new Guid("606d29c4-7610-48ee-871e-d1308167f893"), new Guid("76a19559-5cbf-4441-b354-146a50ad2d2d"), new Guid("1a0a3dfa-6f09-4fa4-820b-22d75ab6ac0f") },
                    { new Guid("b5ceb119-b146-46c1-b577-8d232a76514d"), new Guid("42320546-2688-48a1-8481-913a693aaa0a"), new Guid("7b9bab6e-fd30-411a-b082-6a5dceec665a"), new Guid("34137b96-9b27-4d0e-b11c-ea7946a620ff") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Сharacteristics");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Cameras");

            migrationBuilder.DropTable(
                name: "GeneralCharacteristicsEntity");

            migrationBuilder.DropTable(
                name: "Informations");

            migrationBuilder.DropTable(
                name: "MaterialsEntity");

            migrationBuilder.DropTable(
                name: "MemoryAndProcessors");

            migrationBuilder.DropTable(
                name: "Powers");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Screens");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
