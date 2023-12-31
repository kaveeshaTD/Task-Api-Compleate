﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskApi.DataAcses;

namespace TaskApi.DataAcses.Migrations
{
    [DbContext(typeof(TodoDbcontext))]
    partial class TodoDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TaskApi.Models.Author", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddrssNo")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("jobRole")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("street")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            id = 1,
                            AddrssNo = "50",
                            FullName = "kaveesha",
                            city = "Colombo 1",
                            jobRole = "Developer",
                            street = "street 1"
                        },
                        new
                        {
                            id = 2,
                            AddrssNo = "60",
                            FullName = "Thathsara",
                            city = "Colombo 2",
                            jobRole = "System Engineer",
                            street = "street 2"
                        },
                        new
                        {
                            id = 3,
                            AddrssNo = "70",
                            FullName = "Sandaru",
                            city = "Colombo 3",
                            jobRole = "Developer",
                            street = "street 3"
                        },
                        new
                        {
                            id = 4,
                            AddrssNo = "80",
                            FullName = "Nimesh",
                            city = "Colombo 4",
                            jobRole = "QA",
                            street = "street 4"
                        });
                });

            modelBuilder.Entity("TaskApi.Models.Todo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Authorid")
                        .HasColumnType("int");

                    b.Property<DateTime>("create")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("due")
                        .HasColumnType("datetime2");

                    b.Property<int>("ststus")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("id");

                    b.HasIndex("Authorid");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Authorid = 1,
                            create = new DateTime(2023, 12, 9, 14, 31, 52, 25, DateTimeKind.Local).AddTicks(4311),
                            description = "Get books fro the School new",
                            due = new DateTime(2023, 12, 14, 14, 31, 52, 26, DateTimeKind.Local).AddTicks(3449),
                            ststus = 0,
                            title = "Gets book new from SQl"
                        },
                        new
                        {
                            id = 2,
                            Authorid = 1,
                            create = new DateTime(2023, 12, 9, 14, 31, 52, 26, DateTimeKind.Local).AddTicks(4450),
                            description = "Get spare arts for vehichel new",
                            due = new DateTime(2023, 12, 13, 14, 31, 52, 26, DateTimeKind.Local).AddTicks(4455),
                            ststus = 0,
                            title = "Get car parts new from Sql"
                        },
                        new
                        {
                            id = 3,
                            Authorid = 2,
                            create = new DateTime(2023, 12, 9, 14, 31, 52, 26, DateTimeKind.Local).AddTicks(4464),
                            description = "Get foods for the week new",
                            due = new DateTime(2023, 12, 12, 14, 31, 52, 26, DateTimeKind.Local).AddTicks(4465),
                            ststus = 0,
                            title = "Get Food New from Sql"
                        },
                        new
                        {
                            id = 4,
                            Authorid = 3,
                            create = new DateTime(2023, 12, 9, 14, 31, 52, 26, DateTimeKind.Local).AddTicks(4467),
                            description = "Get medicine Hosptiale new",
                            due = new DateTime(2023, 12, 10, 14, 31, 52, 26, DateTimeKind.Local).AddTicks(4468),
                            ststus = 0,
                            title = "Get Medicine new from Sql"
                        });
                });

            modelBuilder.Entity("TaskApi.Models.Todo", b =>
                {
                    b.HasOne("TaskApi.Models.Author", "Author")
                        .WithMany("todos")
                        .HasForeignKey("Authorid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("TaskApi.Models.Author", b =>
                {
                    b.Navigation("todos");
                });
#pragma warning restore 612, 618
        }
    }
}
