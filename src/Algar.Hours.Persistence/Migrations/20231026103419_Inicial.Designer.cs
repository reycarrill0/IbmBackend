﻿// <auto-generated />
using System;
using Algar.Hours.Persistence.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Algar.Hours.Persistence.Migrations
{
    [DbContext(typeof(DatabaseService))]
    [Migration("20231026103419_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Algar.Hours.Domain.Entities.AssignmentReport.AssignmentReport", b =>
                {
                    b.Property<Guid>("IdAssignmentReport")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateApprovalCancellation")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("HorusReportId")
                        .HasColumnType("uuid");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("IdAssignmentReport");

                    b.HasIndex("HorusReportId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("assignmentReports");
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.Client.ClientEntity", b =>
                {
                    b.Property<Guid>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("NameClient")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdClient");

                    b.ToTable("ClientEntity");
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.Country.CountryEntity", b =>
                {
                    b.Property<Guid>("IdCounty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("NameCountry")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdCounty");

                    b.ToTable("CountryEntity");
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.HorusReport.HorusReportEntity", b =>
                {
                    b.Property<Guid>("IdHorusReport")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ClientEntityId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateApprovalSystem")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TipoReporte")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserEntityId")
                        .HasColumnType("uuid");

                    b.HasKey("IdHorusReport");

                    b.HasIndex("ClientEntityId")
                        .IsUnique();

                    b.HasIndex("UserEntityId")
                        .IsUnique();

                    b.ToTable("HorusReportEntity");
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.Menu.MenuEntity", b =>
                {
                    b.Property<Guid>("IdMenu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("NameMenu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdMenu");

                    b.ToTable("MenuEntity");
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.Parameters.ParametersEntity", b =>
                {
                    b.Property<Guid>("IdParametersEntity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CountryEntityId")
                        .HasColumnType("uuid");

                    b.Property<double>("TargetHourMonth")
                        .HasColumnType("double precision");

                    b.Property<double>("TargetHourWeek")
                        .HasColumnType("double precision");

                    b.Property<double>("TargetTimeDay")
                        .HasColumnType("double precision");

                    b.Property<int>("TypeLimits")
                        .HasColumnType("integer");

                    b.HasKey("IdParametersEntity");

                    b.HasIndex("CountryEntityId")
                        .IsUnique();

                    b.ToTable("ParametersEntity");
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.Rol.RoleEntity", b =>
                {
                    b.Property<Guid>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("NameRole")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdRole");

                    b.ToTable("RoleEntity");
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.RolMenu.RoleMenuEntity", b =>
                {
                    b.Property<Guid>("IdRoleMenu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("MenuEntityId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("IdRoleMenu");

                    b.HasIndex("MenuEntityId")
                        .IsUnique();

                    b.HasIndex("RoleId")
                        .IsUnique();

                    b.ToTable("RoleMenuEntity");
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.User.UserEntity", b =>
                {
                    b.Property<Guid>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CountryEntityId")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EmployeeCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("RoleEntityId")
                        .HasColumnType("uuid");

                    b.Property<string>("surnameUser")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdUser");

                    b.HasIndex("CountryEntityId")
                        .IsUnique();

                    b.HasIndex("RoleEntityId")
                        .IsUnique();

                    b.ToTable("UserEntity");
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.UsersExceptions.UsersExceptions", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("AssignedUserId")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("IdUsersExceptions")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("UserId");

                    b.ToTable("UsersExceptions");
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.AssignmentReport.AssignmentReport", b =>
                {
                    b.HasOne("Algar.Hours.Domain.Entities.HorusReport.HorusReportEntity", "HorusReportEntity")
                        .WithOne("assignmentReport")
                        .HasForeignKey("Algar.Hours.Domain.Entities.AssignmentReport.AssignmentReport", "HorusReportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Algar.Hours.Domain.Entities.User.UserEntity", "UserEntity")
                        .WithOne("AssignmentReport")
                        .HasForeignKey("Algar.Hours.Domain.Entities.AssignmentReport.AssignmentReport", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HorusReportEntity");

                    b.Navigation("UserEntity");
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.HorusReport.HorusReportEntity", b =>
                {
                    b.HasOne("Algar.Hours.Domain.Entities.Client.ClientEntity", "ClientEntity")
                        .WithOne("HorusReportEntity")
                        .HasForeignKey("Algar.Hours.Domain.Entities.HorusReport.HorusReportEntity", "ClientEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Algar.Hours.Domain.Entities.User.UserEntity", "UserEntity")
                        .WithOne("HorusReportEntity")
                        .HasForeignKey("Algar.Hours.Domain.Entities.HorusReport.HorusReportEntity", "UserEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClientEntity");

                    b.Navigation("UserEntity");
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.Parameters.ParametersEntity", b =>
                {
                    b.HasOne("Algar.Hours.Domain.Entities.Country.CountryEntity", "CountryEntity")
                        .WithOne("ParametersEntity")
                        .HasForeignKey("Algar.Hours.Domain.Entities.Parameters.ParametersEntity", "CountryEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CountryEntity");
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.RolMenu.RoleMenuEntity", b =>
                {
                    b.HasOne("Algar.Hours.Domain.Entities.Menu.MenuEntity", "MenuEntity")
                        .WithOne("RolMenuEntity")
                        .HasForeignKey("Algar.Hours.Domain.Entities.RolMenu.RoleMenuEntity", "MenuEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Algar.Hours.Domain.Entities.Rol.RoleEntity", "Role")
                        .WithOne("RolMenuEntity")
                        .HasForeignKey("Algar.Hours.Domain.Entities.RolMenu.RoleMenuEntity", "RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuEntity");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.User.UserEntity", b =>
                {
                    b.HasOne("Algar.Hours.Domain.Entities.Country.CountryEntity", "CountryEntity")
                        .WithOne("User")
                        .HasForeignKey("Algar.Hours.Domain.Entities.User.UserEntity", "CountryEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Algar.Hours.Domain.Entities.Rol.RoleEntity", "RoleEntity")
                        .WithOne("User")
                        .HasForeignKey("Algar.Hours.Domain.Entities.User.UserEntity", "RoleEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CountryEntity");

                    b.Navigation("RoleEntity");
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.UsersExceptions.UsersExceptions", b =>
                {
                    b.HasOne("Algar.Hours.Domain.Entities.User.UserEntity", "User")
                        .WithOne("usersExceptions")
                        .HasForeignKey("Algar.Hours.Domain.Entities.UsersExceptions.UsersExceptions", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.Client.ClientEntity", b =>
                {
                    b.Navigation("HorusReportEntity")
                        .IsRequired();
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.Country.CountryEntity", b =>
                {
                    b.Navigation("ParametersEntity")
                        .IsRequired();

                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.HorusReport.HorusReportEntity", b =>
                {
                    b.Navigation("assignmentReport")
                        .IsRequired();
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.Menu.MenuEntity", b =>
                {
                    b.Navigation("RolMenuEntity")
                        .IsRequired();
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.Rol.RoleEntity", b =>
                {
                    b.Navigation("RolMenuEntity")
                        .IsRequired();

                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("Algar.Hours.Domain.Entities.User.UserEntity", b =>
                {
                    b.Navigation("AssignmentReport")
                        .IsRequired();

                    b.Navigation("HorusReportEntity")
                        .IsRequired();

                    b.Navigation("usersExceptions")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}