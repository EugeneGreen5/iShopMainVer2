using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                name: "characteristic",
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
                    table.PrimaryKey("PK_characteristic", x => x.Id);
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
                });

            migrationBuilder.CreateTable(
                name: "order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderAmount = table.Column<double>(type: "double precision", nullable: false),
                    CreatedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    AddressId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserEntityId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_order_user_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "user",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "selected_product",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductEntityId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserEntityId = table.Column<Guid>(type: "uuid", nullable: true),
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_selected_product", x => new { x.ProductId, x.UserId });
                    table.ForeignKey(
                        name: "FK_selected_product_product_ProductEntityId",
                        column: x => x.ProductEntityId,
                        principalTable: "product",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_selected_product_user_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "user",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "element_order",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductID = table.Column<Guid>(type: "uuid", nullable: false),
                    AmountProduct = table.Column<int>(type: "integer", nullable: false),
                    OrderEntityId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProductEntityId = table.Column<Guid>(type: "uuid", nullable: true),
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_element_order", x => new { x.ProductID, x.OrderId });
                    table.ForeignKey(
                        name: "FK_element_order_order_OrderEntityId",
                        column: x => x.OrderEntityId,
                        principalTable: "order",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_element_order_product_ProductEntityId",
                        column: x => x.ProductEntityId,
                        principalTable: "product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_element_order_OrderEntityId",
                table: "element_order",
                column: "OrderEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_element_order_ProductEntityId",
                table: "element_order",
                column: "ProductEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_order_UserEntityId",
                table: "order",
                column: "UserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_selected_product_ProductEntityId",
                table: "selected_product",
                column: "ProductEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_selected_product_UserEntityId",
                table: "selected_product",
                column: "UserEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "account");

            migrationBuilder.DropTable(
                name: "address");

            migrationBuilder.DropTable(
                name: "camera");

            migrationBuilder.DropTable(
                name: "characteristic");

            migrationBuilder.DropTable(
                name: "element_order");

            migrationBuilder.DropTable(
                name: "general_characteristic");

            migrationBuilder.DropTable(
                name: "information");

            migrationBuilder.DropTable(
                name: "materials");

            migrationBuilder.DropTable(
                name: "memory_and_processor");

            migrationBuilder.DropTable(
                name: "overview");

            migrationBuilder.DropTable(
                name: "power");

            migrationBuilder.DropTable(
                name: "screen");

            migrationBuilder.DropTable(
                name: "selected_product");

            migrationBuilder.DropTable(
                name: "order");

            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
