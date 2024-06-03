﻿// <auto-generated />
using System;
using Identity.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Identity.Migrations
{
    [DbContext(typeof(ForumIdentityDbContext))]
    [Migration("20240603143608_Id08")]
    partial class Id08
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Identity.Models.ForumUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastOnlineTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fa43be6c-a9fb-4c3a-86a5-d002c02fce2b",
                            Email = "admin@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "System",
                            LastName = "Admin",
                            LastOnlineTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEHMREfHYkd2eGM7zsF8P5vPcEBHyttBas+RiCJvy3fBEAzUTBdn1AoKfWCr/PZ/1/A==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "8b4bddbb-bfc8-4039-8e6f-a0146f99eb22",
                            TwoFactorEnabled = false,
                            UserName = "admin@localhost.com"
                        },
                        new
                        {
                            Id = "9e224968-33e4-4652-b7b7-8574d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0161a9fc-f7e2-4ac3-a890-7df9a7644bcb",
                            Email = "user@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "System",
                            LastName = "User",
                            LastOnlineTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@LOCALHOST.COM",
                            NormalizedUserName = "USER@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEI9EMb+JyTvF1U6MUNA6YaXBM2WNYaW0sghG0mhn6rRA6dRNZ2bqmuo6PxbLFXG5rg==",
                            PhoneNumberConfirmed = false,
                            RegisterDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "36902398-e0b3-4934-8d90-a7d6638b9102",
                            TwoFactorEnabled = false,
                            UserName = "user@localhost.com"
                        });
                });

            modelBuilder.Entity("Identity.Models.Permission", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsGranted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentPermissionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PermissionDefinitionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ParentPermissionId");

                    b.HasIndex("PermissionDefinitionId");

                    b.HasIndex("RoleId");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            Id = "dc9aff7b-7de7-4ef3-90a1-047f8ef935f4",
                            IsGranted = true,
                            Name = "FORUM_PROFILE_PAGE",
                            RoleId = "dac42a6e-f7bb-4448-b3cf-1add431ccbbf"
                        },
                        new
                        {
                            Id = "9519adb7-9611-40bc-bd8e-2d71b5097755",
                            IsGranted = true,
                            Name = "FORUM_CAN_OPEN_HEADING",
                            RoleId = "dac42a6e-f7bb-4448-b3cf-1add431ccbbf"
                        },
                        new
                        {
                            Id = "b426d1e0-4afe-4752-abb1-444f593ca9d3",
                            IsGranted = true,
                            Name = "FORUM_CAN_REPLY",
                            RoleId = "dac42a6e-f7bb-4448-b3cf-1add431ccbbf"
                        },
                        new
                        {
                            Id = "a0737557-3282-45eb-b8ed-daa1cc2bc924",
                            IsGranted = true,
                            Name = "FORUM_PROFILE_PAGE",
                            RoleId = "bac43a5e-f7bb-4448-b12f-1add431ccbbf"
                        },
                        new
                        {
                            Id = "0c125c40-7d4e-41de-a00f-c9748142d35a",
                            IsGranted = true,
                            Name = "FORUM_CAN_OPEN_HEADING",
                            RoleId = "bac43a5e-f7bb-4448-b12f-1add431ccbbf"
                        },
                        new
                        {
                            Id = "f46684f5-6513-4a7d-bbdd-0e43a395a38c",
                            IsGranted = true,
                            Name = "FORUM_CAN_REPLY",
                            RoleId = "bac43a5e-f7bb-4448-b12f-1add431ccbbf"
                        },
                        new
                        {
                            Id = "532be471-dd63-4a39-ba2a-4fdc31dc432b",
                            IsGranted = true,
                            Name = "FORUM_PROFILE_PAGE",
                            RoleId = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf"
                        },
                        new
                        {
                            Id = "25315678-0f4a-4a38-b82c-83a130ac4992",
                            IsGranted = true,
                            Name = "FORUM_CAN_OPEN_HEADING",
                            RoleId = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf"
                        },
                        new
                        {
                            Id = "e87f7d83-721e-4e3d-84c4-9b7f48215a84",
                            IsGranted = true,
                            Name = "FORUM_CAN_REPLY",
                            RoleId = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf"
                        });
                });

            modelBuilder.Entity("Identity.Models.PermissionDefinition", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentPermissionDefinitionId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ParentPermissionDefinitionId");

                    b.ToTable("PermissionDefinitions");

                    b.HasData(
                        new
                        {
                            Id = "95e10e0e-7e21-4a7c-849b-30a2e82a61b8",
                            DisplayName = "Forum",
                            Name = "FORUM"
                        },
                        new
                        {
                            Id = "87800b42-e5dc-41e1-845a-789c387a9c8c",
                            DisplayName = "Admin",
                            Name = "ADMIN"
                        },
                        new
                        {
                            Id = "efd0da20-755d-4dcb-a10f-617d84bc52aa",
                            DisplayName = "Post",
                            Name = "FORUM_POST",
                            ParentPermissionDefinitionId = "95e10e0e-7e21-4a7c-849b-30a2e82a61b8"
                        },
                        new
                        {
                            Id = "336e4081-f40d-4e45-bcc5-adb0c04d016f",
                            DisplayName = "Heading",
                            Name = "FORUM_HEADING",
                            ParentPermissionDefinitionId = "95e10e0e-7e21-4a7c-849b-30a2e82a61b8"
                        },
                        new
                        {
                            Id = "d9687026-5c6b-44c8-a4cf-31a7f7ada844",
                            DisplayName = "Section",
                            Name = "FORUM_SECTION",
                            ParentPermissionDefinitionId = "95e10e0e-7e21-4a7c-849b-30a2e82a61b8"
                        },
                        new
                        {
                            Id = "1d42748d-3f19-4f1b-bde0-786a4a245f46",
                            DisplayName = "Category",
                            Name = "FORUM_CATEGORY",
                            ParentPermissionDefinitionId = "95e10e0e-7e21-4a7c-849b-30a2e82a61b8"
                        },
                        new
                        {
                            Id = "8fdcb439-e635-466f-ae81-d7b161fe9a80",
                            DisplayName = "Profile",
                            Name = "FORUM_PROFILE",
                            ParentPermissionDefinitionId = "95e10e0e-7e21-4a7c-849b-30a2e82a61b8"
                        },
                        new
                        {
                            Id = "433a025d-e09e-414c-8fa2-b3d8fc67ecbb",
                            DisplayName = "Message",
                            Name = "FORUM_MESSAGE",
                            ParentPermissionDefinitionId = "95e10e0e-7e21-4a7c-849b-30a2e82a61b8"
                        },
                        new
                        {
                            Id = "8c87ab42-975a-4016-92a8-ec8e34852fbf",
                            DisplayName = "Create Post",
                            Name = "FORUM_POST_CREATE",
                            ParentPermissionDefinitionId = "95e10e0e-7e21-4a7c-849b-30a2e82a61b8"
                        },
                        new
                        {
                            Id = "58b4d6c9-7db7-490b-b118-7fff4839fe69",
                            DisplayName = "Update Post",
                            Name = "FORUM_POST_UPDATE",
                            ParentPermissionDefinitionId = "95e10e0e-7e21-4a7c-849b-30a2e82a61b8"
                        },
                        new
                        {
                            Id = "edae4f5c-d414-4753-b20c-7f6d32b8ed23",
                            DisplayName = "Delete Post",
                            Name = "FORUM_POST_DELETE",
                            ParentPermissionDefinitionId = "95e10e0e-7e21-4a7c-849b-30a2e82a61b8"
                        },
                        new
                        {
                            Id = "6d4df87c-cf17-4db4-90e1-590b68e07e50",
                            DisplayName = "Create Heading",
                            Name = "FORUM_HEADING_CREATE",
                            ParentPermissionDefinitionId = "336e4081-f40d-4e45-bcc5-adb0c04d016f"
                        },
                        new
                        {
                            Id = "4b35a46b-0ee0-48f5-a44f-b1317c4e3af2",
                            DisplayName = "Update Heading",
                            Name = "FORUM_HEADING_UPDATE",
                            ParentPermissionDefinitionId = "336e4081-f40d-4e45-bcc5-adb0c04d016f"
                        },
                        new
                        {
                            Id = "f3311407-5848-4682-98ae-3a02701f1211",
                            DisplayName = "Delete Heading",
                            Name = "FORUM_HEADING_DELETE",
                            ParentPermissionDefinitionId = "336e4081-f40d-4e45-bcc5-adb0c04d016f"
                        },
                        new
                        {
                            Id = "0121f80b-f006-4b98-98b6-72fd0d294a9c",
                            DisplayName = "Create Section",
                            Name = "FORUM_SECTION_CREATE",
                            ParentPermissionDefinitionId = "d9687026-5c6b-44c8-a4cf-31a7f7ada844"
                        },
                        new
                        {
                            Id = "5cdd6187-b295-4ea5-ab2f-18355dab03bc",
                            DisplayName = "Update Section",
                            Name = "FORUM_SECTION_UPDATE",
                            ParentPermissionDefinitionId = "d9687026-5c6b-44c8-a4cf-31a7f7ada844"
                        },
                        new
                        {
                            Id = "36f5b8ce-f602-4268-ac03-047a92f255d8",
                            DisplayName = "Delete Section",
                            Name = "FORUM_SECTION_DELETE",
                            ParentPermissionDefinitionId = "d9687026-5c6b-44c8-a4cf-31a7f7ada844"
                        },
                        new
                        {
                            Id = "32b3175a-dd42-4431-bca1-9ab430ae84df",
                            DisplayName = "Create Category",
                            Name = "FORUM_CATEGORY_CREATE",
                            ParentPermissionDefinitionId = "1d42748d-3f19-4f1b-bde0-786a4a245f46"
                        },
                        new
                        {
                            Id = "72a2d85e-80f4-4bd4-abee-b98842122219",
                            DisplayName = "Update Category",
                            Name = "FORUM_CATEGORY_UPDATE",
                            ParentPermissionDefinitionId = "1d42748d-3f19-4f1b-bde0-786a4a245f46"
                        },
                        new
                        {
                            Id = "f258398c-250e-4d24-8b5b-327b6354f447",
                            DisplayName = "Delete Category",
                            Name = "FORUM_CATEGORY_DELETE",
                            ParentPermissionDefinitionId = "1d42748d-3f19-4f1b-bde0-786a4a245f46"
                        },
                        new
                        {
                            Id = "94466734-1998-4237-90c3-0b3473889dbd",
                            DisplayName = "View Profile Page",
                            Name = "FORUM_PROFILE_VIEW",
                            ParentPermissionDefinitionId = "8fdcb439-e635-466f-ae81-d7b161fe9a80"
                        },
                        new
                        {
                            Id = "03508f20-5c3c-4167-9f41-d8cee9c35620",
                            DisplayName = "Send Message",
                            Name = "FORUM_MESSAGE_SEND",
                            ParentPermissionDefinitionId = "433a025d-e09e-414c-8fa2-b3d8fc67ecbb"
                        },
                        new
                        {
                            Id = "6d807b00-447b-4e7f-8255-99912e4024e4",
                            DisplayName = "Post",
                            Name = "ADMIN_POST",
                            ParentPermissionDefinitionId = "87800b42-e5dc-41e1-845a-789c387a9c8c"
                        },
                        new
                        {
                            Id = "7d6d900a-68bf-4b8c-961e-8a2a6f7f211e",
                            DisplayName = "Heading",
                            Name = "ADMIN_HEADING",
                            ParentPermissionDefinitionId = "87800b42-e5dc-41e1-845a-789c387a9c8c"
                        },
                        new
                        {
                            Id = "f25163b7-43e5-4eba-bccb-95f8d2454f0a",
                            DisplayName = "Section",
                            Name = "ADMIN_SECTION",
                            ParentPermissionDefinitionId = "87800b42-e5dc-41e1-845a-789c387a9c8c"
                        },
                        new
                        {
                            Id = "d2a3ae9f-c13e-459d-b5b6-3fe5937cceb4",
                            DisplayName = "Category",
                            Name = "ADMIN_CATEGORY",
                            ParentPermissionDefinitionId = "87800b42-e5dc-41e1-845a-789c387a9c8c"
                        },
                        new
                        {
                            Id = "aa55c85d-33ad-45ee-9dff-6d78aaf86a9c",
                            DisplayName = "Create Post",
                            Name = "ADMIN_POST_CREATE",
                            ParentPermissionDefinitionId = "6d807b00-447b-4e7f-8255-99912e4024e4"
                        },
                        new
                        {
                            Id = "69860332-d98b-45c5-b3df-0a3ea6d02bda",
                            DisplayName = "Update Post",
                            Name = "ADMIN_POST_UPDATE",
                            ParentPermissionDefinitionId = "6d807b00-447b-4e7f-8255-99912e4024e4"
                        },
                        new
                        {
                            Id = "29a67ad6-4f24-42fa-b79c-18aa350fe224",
                            DisplayName = "Delete Post",
                            Name = "ADMIN_POST_DELETE",
                            ParentPermissionDefinitionId = "6d807b00-447b-4e7f-8255-99912e4024e4"
                        },
                        new
                        {
                            Id = "9f24f6b8-d146-47b6-b09b-780983b14521",
                            DisplayName = "Create Heading",
                            Name = "ADMIN_HEADING_CREATE",
                            ParentPermissionDefinitionId = "7d6d900a-68bf-4b8c-961e-8a2a6f7f211e"
                        },
                        new
                        {
                            Id = "70be0e0a-8d40-4c72-a0d4-aeef641dbc8f",
                            DisplayName = "Update Heading",
                            Name = "ADMIN_HEADING_UPDATE",
                            ParentPermissionDefinitionId = "7d6d900a-68bf-4b8c-961e-8a2a6f7f211e"
                        },
                        new
                        {
                            Id = "affe5dc6-b91c-430b-8516-eb8a80714b7b",
                            DisplayName = "Delete Heading",
                            Name = "ADMIN_HEADING_DELETE",
                            ParentPermissionDefinitionId = "7d6d900a-68bf-4b8c-961e-8a2a6f7f211e"
                        },
                        new
                        {
                            Id = "3059ac0b-ecf8-4e95-acd7-f2a5378886fb",
                            DisplayName = "Create Section",
                            Name = "ADMIN_SECTION_CREATE",
                            ParentPermissionDefinitionId = "f25163b7-43e5-4eba-bccb-95f8d2454f0a"
                        },
                        new
                        {
                            Id = "68992dc4-c2d2-4479-bf0c-f33d4a511a9d",
                            DisplayName = "Update Section",
                            Name = "ADMIN_SECTION_UPDATE",
                            ParentPermissionDefinitionId = "f25163b7-43e5-4eba-bccb-95f8d2454f0a"
                        },
                        new
                        {
                            Id = "206707f8-5625-4949-ac64-7c54ab7f82a5",
                            DisplayName = "Delete Section",
                            Name = "ADMIN_SECTION_DELETE",
                            ParentPermissionDefinitionId = "f25163b7-43e5-4eba-bccb-95f8d2454f0a"
                        },
                        new
                        {
                            Id = "8e3404a5-4929-449b-ad84-e83efeda6290",
                            DisplayName = "Create Category",
                            Name = "ADMIN_CATEGORY_CREATE",
                            ParentPermissionDefinitionId = "d2a3ae9f-c13e-459d-b5b6-3fe5937cceb4"
                        },
                        new
                        {
                            Id = "4e479fa5-ad75-4c84-9e61-fda5d262b63b",
                            DisplayName = "Update Category",
                            Name = "ADMIN_CATEGORY_UPDATE",
                            ParentPermissionDefinitionId = "d2a3ae9f-c13e-459d-b5b6-3fe5937cceb4"
                        },
                        new
                        {
                            Id = "8af1ed15-b6f0-46bf-97ba-026273eb55fd",
                            DisplayName = "Delete Category",
                            Name = "ADMIN_CATEGORY_DELETE",
                            ParentPermissionDefinitionId = "d2a3ae9f-c13e-459d-b5b6-3fe5937cceb4"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "dac42a6e-f7bb-4448-b3cf-1add431ccbbf",
                            Name = "Member",
                            NormalizedName = "MEMBER"
                        },
                        new
                        {
                            Id = "bac43a5e-f7bb-4448-b12f-1add431ccbbf",
                            Name = "Moderator",
                            NormalizedName = "MODERATOR"
                        },
                        new
                        {
                            Id = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            RoleId = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf"
                        },
                        new
                        {
                            UserId = "9e224968-33e4-4652-b7b7-8574d048cdb9",
                            RoleId = "cac43a6e-f7bb-4448-baaf-1add431ccbbf"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("Identity.Models.Permission", b =>
                {
                    b.HasOne("Identity.Models.Permission", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentPermissionId");

                    b.HasOne("Identity.Models.PermissionDefinition", "PermissionDefinition")
                        .WithMany()
                        .HasForeignKey("PermissionDefinitionId");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Parent");

                    b.Navigation("PermissionDefinition");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Identity.Models.PermissionDefinition", b =>
                {
                    b.HasOne("Identity.Models.PermissionDefinition", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentPermissionDefinitionId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Identity.Models.ForumUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Identity.Models.ForumUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Identity.Models.ForumUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Identity.Models.ForumUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
