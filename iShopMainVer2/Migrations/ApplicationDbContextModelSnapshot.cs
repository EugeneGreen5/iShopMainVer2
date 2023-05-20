﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using iShopMain.Data;

#nullable disable

namespace iShopMainVer2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("iShopMain.Models.Entity.UserInfo.AccountEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("account", (string)null);
                });

            modelBuilder.Entity("iShopMain.Models.Entity.UserInfo.InformationEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("DateOfRegistration")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("information", (string)null);
                });

            modelBuilder.Entity("iShopMain.Models.Entity.UserInfo.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("InformationId")
                        .HasColumnType("uuid");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("iShopMainVer2.Models.Entity.Characteristic.CameraEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("MainCamera")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MaximumFrequencyVideo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MaximumResolutionVideo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UltraWideAngleCamera")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WebCamera")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ZoomCamera")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("camera", (string)null);
                });

            modelBuilder.Entity("iShopMainVer2.Models.Entity.Characteristic.CharacteristicEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CameraId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("GeneralCharacteristicsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("MaterialId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("MemoryAndProcessorId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PowerId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ScreenId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("characteristic", (string)null);
                });

            modelBuilder.Entity("iShopMainVer2.Models.Entity.Characteristic.GeneralCharacteristicEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OperationSystem")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ProductServiceLife")
                        .HasColumnType("integer");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("WarrantyPeriod")
                        .HasColumnType("integer");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("general_characteristic", (string)null);
                });

            modelBuilder.Entity("iShopMainVer2.Models.Entity.Characteristic.MaterialsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("MaterialBody")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("materials", (string)null);
                });

            modelBuilder.Entity("iShopMainVer2.Models.Entity.Characteristic.MemoryAndProcessorEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("NumberOfProcessorCores")
                        .HasColumnType("integer");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("memory_and_processor", (string)null);
                });

            modelBuilder.Entity("iShopMainVer2.Models.Entity.Characteristic.PowerEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("BatteryCapacity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsFastCharging")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPowerUnit")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsWirelessCharging")
                        .HasColumnType("boolean");

                    b.Property<string>("TypeOfChargingConnector")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WorkingHours")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("power", (string)null);
                });

            modelBuilder.Entity("iShopMainVer2.Models.Entity.Characteristic.ScreenEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("DiagonalScreen")
                        .HasColumnType("integer");

                    b.Property<int>("FrequencyScreen")
                        .HasColumnType("integer");

                    b.Property<bool>("IsTouchScreen")
                        .HasColumnType("boolean");

                    b.Property<string>("ResolutionScreen")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TypeScreen")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("screen", (string)null);
                });

            modelBuilder.Entity("iShopMainVer2.Models.Entity.Order.AddressEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Entrance")
                        .HasColumnType("integer");

                    b.Property<int>("Flat")
                        .HasColumnType("integer");

                    b.Property<int>("Floor")
                        .HasColumnType("integer");

                    b.Property<int>("House")
                        .HasColumnType("integer");

                    b.Property<int>("Housing")
                        .HasColumnType("integer");

                    b.Property<int>("Index")
                        .HasColumnType("integer");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("address", (string)null);
                });

            modelBuilder.Entity("iShopMainVer2.Models.Entity.Order.ElementOrderEntity", b =>
                {
                    b.Property<Guid>("ProductID")
                        .HasColumnType("uuid");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<int>("AmountProduct")
                        .HasColumnType("integer");

                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("OrderEntityId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ProductEntityId")
                        .HasColumnType("uuid");

                    b.HasKey("ProductID", "OrderId");

                    b.HasIndex("OrderEntityId");

                    b.HasIndex("ProductEntityId");

                    b.ToTable("element_order", (string)null);
                });

            modelBuilder.Entity("iShopMainVer2.Models.Entity.Order.OrderEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<double>("OrderAmount")
                        .HasColumnType("double precision");

                    b.Property<Guid?>("UserEntityId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.ToTable("order", (string)null);
                });

            modelBuilder.Entity("iShopMainVer2.Models.Entity.Products.OverviewEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("overview", (string)null);
                });

            modelBuilder.Entity("iShopMainVer2.Models.Entity.Products.ProductEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CharacteristicId")
                        .HasColumnType("uuid");

                    b.Property<int>("CountOnWarehouse")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("OverviewId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("product", (string)null);
                });

            modelBuilder.Entity("iShopMainVer2.Models.Entity.Products.SelectedProductEntity", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ProductEntityId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserEntityId")
                        .HasColumnType("uuid");

                    b.HasKey("ProductId", "UserId");

                    b.HasIndex("ProductEntityId");

                    b.HasIndex("UserEntityId");

                    b.ToTable("selected_product", (string)null);
                });

            modelBuilder.Entity("iShopMainVer2.Models.Entity.Order.ElementOrderEntity", b =>
                {
                    b.HasOne("iShopMainVer2.Models.Entity.Order.OrderEntity", null)
                        .WithMany("Elements")
                        .HasForeignKey("OrderEntityId");

                    b.HasOne("iShopMainVer2.Models.Entity.Products.ProductEntity", null)
                        .WithMany("ElementOrders")
                        .HasForeignKey("ProductEntityId");
                });

            modelBuilder.Entity("iShopMainVer2.Models.Entity.Order.OrderEntity", b =>
                {
                    b.HasOne("iShopMain.Models.Entity.UserInfo.UserEntity", null)
                        .WithMany("OrderList")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("iShopMainVer2.Models.Entity.Products.SelectedProductEntity", b =>
                {
                    b.HasOne("iShopMainVer2.Models.Entity.Products.ProductEntity", null)
                        .WithMany("SelectedProducts")
                        .HasForeignKey("ProductEntityId");

                    b.HasOne("iShopMain.Models.Entity.UserInfo.UserEntity", null)
                        .WithMany("SelectedProducts")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("iShopMain.Models.Entity.UserInfo.UserEntity", b =>
                {
                    b.Navigation("OrderList");

                    b.Navigation("SelectedProducts");
                });

            modelBuilder.Entity("iShopMainVer2.Models.Entity.Order.OrderEntity", b =>
                {
                    b.Navigation("Elements");
                });

            modelBuilder.Entity("iShopMainVer2.Models.Entity.Products.ProductEntity", b =>
                {
                    b.Navigation("ElementOrders");

                    b.Navigation("SelectedProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
