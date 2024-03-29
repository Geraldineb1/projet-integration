﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(PropagendaDbContext))]
    [Migration("20230429121116_AddImageToProvider")]
    partial class AddImageToProvider
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
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

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "279fc88b-0a5e-4bec-b074-eee865a0c9ae",
                            AccessFailedCount = 0,
                            Address = "rue de la paix 25",
                            ConcurrencyStamp = "f7128203-7805-44a9-8506-efc5eb68d352",
                            Email = "admin@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "System",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAuN+YRWj2zA7Xa/Z5OunVbSpangk0+vw/dHZZAu8TyN6kyjq6Li6CPESDidKT8WKA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8db21426-850e-449e-8863-c3a86432fe09",
                            TwoFactorEnabled = false,
                            UserName = "admin@localhost.com"
                        },
                        new
                        {
                            Id = "047a1feb-b527-43af-8194-f1e3c92b7607",
                            AccessFailedCount = 0,
                            Address = "rue de la paix 25",
                            ConcurrencyStamp = "97087462-484b-4af6-8b28-70d471f97803",
                            Email = "employee@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "System",
                            LastName = "Employee",
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPLOYEE@LOCALHOST.COM",
                            NormalizedUserName = "EMPLOYEE@LOCALHOST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMhxesB6ILM3PMO1VomNbHZcrIallUjj2MTP7LfoiYMThgl7UnTIfe3qSupcPdD3fQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2af37b5a-a607-4101-a06f-eda48c67ef71",
                            TwoFactorEnabled = false,
                            UserName = "employee@localhost.com"
                        },
                        new
                        {
                            Id = "ed742fb6-87ff-40a9-a30b-717211f5d456",
                            AccessFailedCount = 0,
                            Address = "rue de la paix 25",
                            ConcurrencyStamp = "22fff8e6-337a-4d3f-b594-a56986e967dc",
                            Email = "clien@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "System",
                            LastName = "Client",
                            LockoutEnabled = false,
                            NormalizedEmail = "CLIENT@LOCALHOST.COM",
                            NormalizedUserName = "CLIENT@LOCALHOST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGgiDBrNVKgK4IGRAq+qfOkPCZkCw/7C0vF08Evr0vJ+qufzrWGCI1yu/68nCqKDoQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "91178d50-47ff-487d-8f7b-6491d3e9cbbc",
                            TwoFactorEnabled = false,
                            UserName = "client@localhost.com"
                        });
                });

            modelBuilder.Entity("Domain.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPromoted")
                        .HasColumnType("bit");

                    b.Property<int>("NbSoldTickets")
                        .HasColumnType("int");

                    b.Property<int>("TicketPrice")
                        .HasColumnType("int");

                    b.Property<int>("TicketsAmount")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VenueAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VenueName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Domain.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPromoted")
                        .HasColumnType("bit");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("Domain.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPromoted")
                        .HasColumnType("bit");

                    b.Property<string>("LocationAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isApproved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ProviderId");

                    b.HasIndex("ServiceTypeId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Domain.ServiceReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateService")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("ServiceReservations");
                });

            modelBuilder.Entity("Domain.ServiceServiceReservation", b =>
                {
                    b.Property<int>("ServicesId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceReservationsId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("ServicesId", "ServiceReservationsId");

                    b.HasIndex("ServiceReservationsId");

                    b.ToTable("ServiceServiceReservation");
                });

            modelBuilder.Entity("Domain.ServiceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ServiceTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "urlpardefaut",
                            Label = "Concert"
                        },
                        new
                        {
                            Id = 2,
                            Image = "urlpardefaut",
                            Label = "Securité"
                        },
                        new
                        {
                            Id = 3,
                            Image = "urlpardefaut",
                            Label = "Technique"
                        });
                });

            modelBuilder.Entity("Domain.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("TicketNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Domain.TicketReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("TotalNbTickets")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("EventId");

                    b.ToTable("TicketReservations");
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

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                            ConcurrencyStamp = "b2bbcefd-b3dd-42be-b9cf-df75c74bfeb2",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                            ConcurrencyStamp = "c5d3e11f-88c4-472d-a5d3-8ea4da6ec751",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "cbc43a9e-f7bb-4445-baaf-1add431ffbbf",
                            ConcurrencyStamp = "7a752714-499a-4b47-a1a0-c22cb9fb7927",
                            Name = "Client",
                            NormalizedName = "CLIENT"
                        },
                        new
                        {
                            Id = "8d012e04-e5c3-4ee0-baed-53d4778470a6",
                            ConcurrencyStamp = "45428461-7b8f-4d5c-90ad-89fda122e77a",
                            Name = "Provider",
                            NormalizedName = "PROVIDER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "279fc88b-0a5e-4bec-b074-eee865a0c9ae",
                            RoleId = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf"
                        },
                        new
                        {
                            UserId = "047a1feb-b527-43af-8194-f1e3c92b7607",
                            RoleId = "cac43a6e-f7bb-4448-baaf-1add431ccbbf"
                        },
                        new
                        {
                            UserId = "ed742fb6-87ff-40a9-a30b-717211f5d456",
                            RoleId = "cbc43a9e-f7bb-4445-baaf-1add431ffbbf"
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Domain.Event", b =>
                {
                    b.HasOne("Domain.ApplicationUser", "ApplicationUser")
                        .WithMany("Events")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Domain.Provider", b =>
                {
                    b.HasOne("Domain.ApplicationUser", "ApplicationUser")
                        .WithMany("Providers")
                        .HasForeignKey("ApplicationUserId");

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Domain.Service", b =>
                {
                    b.HasOne("Domain.Provider", "Provider")
                        .WithMany("Services")
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.ServiceType", "ServiceType")
                        .WithMany("Services")
                        .HasForeignKey("ServiceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provider");

                    b.Navigation("ServiceType");
                });

            modelBuilder.Entity("Domain.ServiceReservation", b =>
                {
                    b.HasOne("Domain.ApplicationUser", "ApplicationUser")
                        .WithMany("ServicesReservations")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Domain.ServiceServiceReservation", b =>
                {
                    b.HasOne("Domain.ServiceReservation", "ServiceReservation")
                        .WithMany("SSR")
                        .HasForeignKey("ServiceReservationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Service", "Service")
                        .WithMany("SSR")
                        .HasForeignKey("ServicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Service");

                    b.Navigation("ServiceReservation");
                });

            modelBuilder.Entity("Domain.Ticket", b =>
                {
                    b.HasOne("Domain.Event", "Event")
                        .WithMany("TicketList")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("Domain.TicketReservation", b =>
                {
                    b.HasOne("Domain.ApplicationUser", "ApplicationUser")
                        .WithMany("TicketReservations")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Event", "Event")
                        .WithMany("TicketReservation")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Event");
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
                    b.HasOne("Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Domain.ApplicationUser", null)
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

                    b.HasOne("Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.ApplicationUser", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("Providers");

                    b.Navigation("ServicesReservations");

                    b.Navigation("TicketReservations");
                });

            modelBuilder.Entity("Domain.Event", b =>
                {
                    b.Navigation("TicketList");

                    b.Navigation("TicketReservation");
                });

            modelBuilder.Entity("Domain.Provider", b =>
                {
                    b.Navigation("Services");
                });

            modelBuilder.Entity("Domain.Service", b =>
                {
                    b.Navigation("SSR");
                });

            modelBuilder.Entity("Domain.ServiceReservation", b =>
                {
                    b.Navigation("SSR");
                });

            modelBuilder.Entity("Domain.ServiceType", b =>
                {
                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
