﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using iShopMain.Data;

#nullable disable

namespace iShopMainVer2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230418144636_initDbWithFakeNews")]
    partial class initDbWithFakeNews
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("iShopMain.Models.Entity.UserInfo.Account", b =>
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

                    b.ToTable("accounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e36d22ad-68b4-4fdf-ad6f-7f42a0cd4677"),
                            Login = "alesha@mail.ru",
                            Password = "3C9909AFEC25354D551DAE21590BB26E38D53F2173B8D3DC3EEE4C047E7AB1C1EB8B85103E3BE7BA613B31BB5C9C36214DC9F14A42FD7A2FDB84856BCA5C44C2"
                        },
                        new
                        {
                            Id = new Guid("8e3b87fe-a2f6-489d-9419-4c052b7e255b"),
                            Login = "petr@gmail.com",
                            Password = "3043AA4A83B0934982956A90828140CB834869135B5F294938865DE12E036DE440A330E1E8529BEC15DDD59F18D1161A97BFEC110D2622680F2C714A737D7061"
                        });
                });

            modelBuilder.Entity("iShopMain.Models.Entity.UserInfo.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("InformationId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("15eeacd7-5cc4-427f-9a92-43f5046afeab"),
                            AccountId = new Guid("e36d22ad-68b4-4fdf-ad6f-7f42a0cd4677"),
                            InformationId = new Guid("e355c9d5-bd48-4587-99fa-20f2074d9398"),
                            RoleId = new Guid("3ceb511a-8762-4f8e-a327-876ba3293dff")
                        },
                        new
                        {
                            Id = new Guid("63fdef27-4d83-4d93-8c57-e12c91cae8ec"),
                            AccountId = new Guid("8e3b87fe-a2f6-489d-9419-4c052b7e255b"),
                            InformationId = new Guid("82c4dec5-669f-40ab-b21e-3785081b1e83"),
                            RoleId = new Guid("a7458abd-e2f3-4351-b772-3187b97a626a")
                        });
                });

            modelBuilder.Entity("iShopMain.Models.Entity.UserInfo.Information", b =>
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

                    b.ToTable("informations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e355c9d5-bd48-4587-99fa-20f2074d9398"),
                            DateOfRegistration = new DateOnly(2023, 4, 18),
                            Email = "alesha@mail.ru",
                            Name = "Алексей",
                            Patronymic = "Васильевич",
                            PhoneNumber = "+32112345698",
                            Surname = "Иванов"
                        },
                        new
                        {
                            Id = new Guid("82c4dec5-669f-40ab-b21e-3785081b1e83"),
                            DateOfRegistration = new DateOnly(2023, 4, 18),
                            Email = "petr@gmail.com",
                            Name = "Petr",
                            Patronymic = "Sergeevich",
                            PhoneNumber = "+12345689093",
                            Surname = "Vasiliev"
                        });
                });

            modelBuilder.Entity("iShopMain.Models.Entity.UserInfo.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("NameRole")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3ceb511a-8762-4f8e-a327-876ba3293dff"),
                            NameRole = "user"
                        },
                        new
                        {
                            Id = new Guid("a7458abd-e2f3-4351-b772-3187b97a626a"),
                            NameRole = "admin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}