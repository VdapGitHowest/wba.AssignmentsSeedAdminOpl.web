﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wba.Assignments.web.Data;

#nullable disable

namespace wba.Assignments.web.Migrations
{
    [DbContext(typeof(AssignmentDBContext))]
    [Migration("20240321165012_AddSeedingEmployeeProjects")]
    partial class AddSeedingEmployeeProjects
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeProject", b =>
                {
                    b.Property<int>("AssignedEmployeesId")
                        .HasColumnType("int");

                    b.Property<int>("AssignedProjectsId")
                        .HasColumnType("int");

                    b.HasKey("AssignedEmployeesId", "AssignedProjectsId");

                    b.HasIndex("AssignedProjectsId");

                    b.ToTable("EmployeeProject");

                    b.HasData(
                        new
                        {
                            AssignedEmployeesId = 1,
                            AssignedProjectsId = 1
                        },
                        new
                        {
                            AssignedEmployeesId = 1,
                            AssignedProjectsId = 2
                        },
                        new
                        {
                            AssignedEmployeesId = 4,
                            AssignedProjectsId = 1
                        },
                        new
                        {
                            AssignedEmployeesId = 3,
                            AssignedProjectsId = 2
                        });
                });

            modelBuilder.Entity("wba.Assignments.core.entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 3, 21, 16, 50, 11, 753, DateTimeKind.Utc).AddTicks(315),
                            Department = "IT",
                            Name = "Peter Van Damme",
                            Position = "Developer"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2024, 3, 21, 16, 50, 11, 753, DateTimeKind.Utc).AddTicks(318),
                            Department = "IT",
                            Name = "Kris Meert",
                            Position = "Analyst"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 3, 21, 16, 50, 11, 753, DateTimeKind.Utc).AddTicks(319),
                            Department = "IT",
                            Name = "Ann Verboost",
                            Position = "AI-specialist"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2024, 3, 21, 16, 50, 11, 753, DateTimeKind.Utc).AddTicks(320),
                            Department = "IT",
                            Name = "Rudy Minneboom",
                            Position = "DPO"
                        });
                });

            modelBuilder.Entity("wba.Assignments.core.entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Redesigning the company website to improve user experience and add new features.",
                            EndDate = new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Website Redesign",
                            StartDate = new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Launching a new product in the market with extensive marketing campaigns.",
                            EndDate = new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Product Launch",
                            StartDate = new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Implementing a training program for employees to enhance skills and productivity.",
                            EndDate = new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Internal Training Program",
                            StartDate = new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("EmployeeProject", b =>
                {
                    b.HasOne("wba.Assignments.core.entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("AssignedEmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wba.Assignments.core.entities.Project", null)
                        .WithMany()
                        .HasForeignKey("AssignedProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
