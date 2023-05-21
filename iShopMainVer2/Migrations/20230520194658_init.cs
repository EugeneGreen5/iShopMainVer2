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
                name: "account",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Login = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "camera",
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
                    table.PrimaryKey("PK_camera", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "general_characteristic",
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
                    table.PrimaryKey("PK_general_characteristic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "information",
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
                    table.PrimaryKey("PK_information", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "materials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MaterialBody = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "memory_and_processor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Processor = table.Column<string>(type: "text", nullable: false),
                    NumberOfProcessorCores = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_memory_and_processor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "overview",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_overview", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "power",
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
                    table.PrimaryKey("PK_power", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "screen",
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
                    table.PrimaryKey("PK_screen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AccountId = table.Column<Guid>(type: "uuid", nullable: false),
                    InformationId = table.Column<Guid>(type: "uuid", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                    table.ForeignKey(
                        name: "FK_user_account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_information_InformationId",
                        column: x => x.InformationId,
                        principalTable: "information",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "characteristic",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GeneralCharacteristicsId = table.Column<Guid>(type: "uuid", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uuid", nullable: false),
                    MemoryAndProcessorId = table.Column<Guid>(type: "uuid", nullable: false),
                    ScreenId = table.Column<Guid>(type: "uuid", nullable: false),
                    CameraId = table.Column<Guid>(type: "uuid", nullable: false),
                    PowerId = table.Column<Guid>(type: "uuid", nullable: false),
                    GeneralCharacteristicEntityId = table.Column<Guid>(type: "uuid", nullable: false),
                    MaterialsEntityId = table.Column<Guid>(type: "uuid", nullable: false),
                    MemoryAndProcessorEntityId = table.Column<Guid>(type: "uuid", nullable: false),
                    ScreenEntityId = table.Column<Guid>(type: "uuid", nullable: false),
                    CameraEntityId = table.Column<Guid>(type: "uuid", nullable: false),
                    PowerEntityId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_characteristic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_characteristic_camera_CameraEntityId",
                        column: x => x.CameraEntityId,
                        principalTable: "camera",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_characteristic_general_characteristic_GeneralCharacteristic~",
                        column: x => x.GeneralCharacteristicEntityId,
                        principalTable: "general_characteristic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_characteristic_materials_MaterialsEntityId",
                        column: x => x.MaterialsEntityId,
                        principalTable: "materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_characteristic_memory_and_processor_MemoryAndProcessorEntit~",
                        column: x => x.MemoryAndProcessorEntityId,
                        principalTable: "memory_and_processor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_characteristic_power_PowerEntityId",
                        column: x => x.PowerEntityId,
                        principalTable: "power",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_characteristic_screen_ScreenEntityId",
                        column: x => x.ScreenEntityId,
                        principalTable: "screen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderAmount = table.Column<double>(type: "double precision", nullable: false),
                    CreatedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    AddressId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order", x => x.Id);
                    table.UniqueConstraint("AK_order_AddressId", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_order_user_UserId",
                        column: x => x.UserId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CountOnWarehouse = table.Column<int>(type: "integer", nullable: false),
                    OverviewId = table.Column<Guid>(type: "uuid", nullable: false),
                    CharacteristicId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_product_characteristic_CharacteristicId",
                        column: x => x.CharacteristicId,
                        principalTable: "characteristic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_product_overview_OverviewId",
                        column: x => x.OverviewId,
                        principalTable: "overview",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Index = table.Column<int>(type: "integer", nullable: false),
                    Region = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    Street = table.Column<string>(type: "text", nullable: false),
                    Housing = table.Column<int>(type: "integer", nullable: false),
                    House = table.Column<int>(type: "integer", nullable: false),
                    Entrance = table.Column<int>(type: "integer", nullable: false),
                    Floor = table.Column<int>(type: "integer", nullable: false),
                    Flat = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_address_order_Id",
                        column: x => x.Id,
                        principalTable: "order",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "element_order",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    AmountProduct = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_element_order", x => new { x.ProductId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_element_order_order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_element_order_product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "selected_product",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_selected_product", x => new { x.ProductId, x.UserId });
                    table.ForeignKey(
                        name: "FK_selected_product_product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_selected_product_user_UserId",
                        column: x => x.UserId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "account",
                columns: new[] { "Id", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("5afe3981-5971-4c0e-817c-94350534b6ff"), "alesha@mail.ru", "3C9909AFEC25354D551DAE21590BB26E38D53F2173B8D3DC3EEE4C047E7AB1C1EB8B85103E3BE7BA613B31BB5C9C36214DC9F14A42FD7A2FDB84856BCA5C44C2" },
                    { new Guid("ad8b5f49-09b0-43b7-96d9-0287e1ed00de"), "petr@gmail.com", "3043AA4A83B0934982956A90828140CB834869135B5F294938865DE12E036DE440A330E1E8529BEC15DDD59F18D1161A97BFEC110D2622680F2C714A737D7061" }
                });

            migrationBuilder.InsertData(
                table: "information",
                columns: new[] { "Id", "DateOfRegistration", "Email", "Name", "Patronymic", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { new Guid("18b92259-a31d-484e-836a-3bf91b6c1e26"), new DateOnly(2023, 5, 20), "alesha@mail.ru", "Алексей", "Васильевич", "+32112345698", "Иванов" },
                    { new Guid("59204603-a957-4481-a1b0-f7a0613c647c"), new DateOnly(2023, 5, 20), "petr@gmail.com", "Petr", "Sergeevich", "+12345689093", "Vasiliev" }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "Id", "AccountId", "InformationId", "Role" },
                values: new object[,]
                {
                    { new Guid("2d36ba0c-b580-4843-8440-e553f2939449"), new Guid("5afe3981-5971-4c0e-817c-94350534b6ff"), new Guid("18b92259-a31d-484e-836a-3bf91b6c1e26"), "user" },
                    { new Guid("aae3e209-cba1-4d1a-982f-13a035f2eff1"), new Guid("ad8b5f49-09b0-43b7-96d9-0287e1ed00de"), new Guid("59204603-a957-4481-a1b0-f7a0613c647c"), "admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_characteristic_CameraEntityId",
                table: "characteristic",
                column: "CameraEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_characteristic_GeneralCharacteristicEntityId",
                table: "characteristic",
                column: "GeneralCharacteristicEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_characteristic_MaterialsEntityId",
                table: "characteristic",
                column: "MaterialsEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_characteristic_MemoryAndProcessorEntityId",
                table: "characteristic",
                column: "MemoryAndProcessorEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_characteristic_PowerEntityId",
                table: "characteristic",
                column: "PowerEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_characteristic_ScreenEntityId",
                table: "characteristic",
                column: "ScreenEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_element_order_OrderId",
                table: "element_order",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_order_UserId",
                table: "order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_product_CharacteristicId",
                table: "product",
                column: "CharacteristicId");

            migrationBuilder.CreateIndex(
                name: "IX_product_OverviewId",
                table: "product",
                column: "OverviewId");

            migrationBuilder.CreateIndex(
                name: "IX_selected_product_UserId",
                table: "selected_product",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_user_AccountId",
                table: "user",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_user_InformationId",
                table: "user",
                column: "InformationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "address");

            migrationBuilder.DropTable(
                name: "element_order");

            migrationBuilder.DropTable(
                name: "selected_product");

            migrationBuilder.DropTable(
                name: "order");

            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "characteristic");

            migrationBuilder.DropTable(
                name: "overview");

            migrationBuilder.DropTable(
                name: "account");

            migrationBuilder.DropTable(
                name: "information");

            migrationBuilder.DropTable(
                name: "camera");

            migrationBuilder.DropTable(
                name: "general_characteristic");

            migrationBuilder.DropTable(
                name: "materials");

            migrationBuilder.DropTable(
                name: "memory_and_processor");

            migrationBuilder.DropTable(
                name: "power");

            migrationBuilder.DropTable(
                name: "screen");
        }
    }
}
