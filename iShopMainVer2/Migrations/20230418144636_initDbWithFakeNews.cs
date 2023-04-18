using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iShopMainVer2.Migrations
{
    /// <inheritdoc />
    public partial class initDbWithFakeNews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Login = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "informations",
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
                    table.PrimaryKey("PK_informations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NameRole = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AccountId = table.Column<Guid>(type: "uuid", nullable: false),
                    InformationId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "accounts",
                columns: new[] { "Id", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("8e3b87fe-a2f6-489d-9419-4c052b7e255b"), "petr@gmail.com", "3043AA4A83B0934982956A90828140CB834869135B5F294938865DE12E036DE440A330E1E8529BEC15DDD59F18D1161A97BFEC110D2622680F2C714A737D7061" },
                    { new Guid("e36d22ad-68b4-4fdf-ad6f-7f42a0cd4677"), "alesha@mail.ru", "3C9909AFEC25354D551DAE21590BB26E38D53F2173B8D3DC3EEE4C047E7AB1C1EB8B85103E3BE7BA613B31BB5C9C36214DC9F14A42FD7A2FDB84856BCA5C44C2" }
                });

            migrationBuilder.InsertData(
                table: "informations",
                columns: new[] { "Id", "DateOfRegistration", "Email", "Name", "Patronymic", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { new Guid("82c4dec5-669f-40ab-b21e-3785081b1e83"), new DateOnly(2023, 4, 18), "petr@gmail.com", "Petr", "Sergeevich", "+12345689093", "Vasiliev" },
                    { new Guid("e355c9d5-bd48-4587-99fa-20f2074d9398"), new DateOnly(2023, 4, 18), "alesha@mail.ru", "Алексей", "Васильевич", "+32112345698", "Иванов" }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Id", "NameRole" },
                values: new object[,]
                {
                    { new Guid("3ceb511a-8762-4f8e-a327-876ba3293dff"), "user" },
                    { new Guid("a7458abd-e2f3-4351-b772-3187b97a626a"), "admin" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "AccountId", "InformationId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("15eeacd7-5cc4-427f-9a92-43f5046afeab"), new Guid("e36d22ad-68b4-4fdf-ad6f-7f42a0cd4677"), new Guid("e355c9d5-bd48-4587-99fa-20f2074d9398"), new Guid("3ceb511a-8762-4f8e-a327-876ba3293dff") },
                    { new Guid("63fdef27-4d83-4d93-8c57-e12c91cae8ec"), new Guid("8e3b87fe-a2f6-489d-9419-4c052b7e255b"), new Guid("82c4dec5-669f-40ab-b21e-3785081b1e83"), new Guid("a7458abd-e2f3-4351-b772-3187b97a626a") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropTable(
                name: "informations");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
