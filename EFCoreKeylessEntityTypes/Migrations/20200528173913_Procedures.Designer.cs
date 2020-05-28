﻿// <auto-generated />
using EFCoreKeylessEntityTypes.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreKeylessEntityTypes.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200528173913_Procedures")]
    partial class Procedures
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreKeylessEntityTypes.Entities.QLink", b =>
                {
                    b.Property<string>("QNumber")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("QGroup")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("QNumber");

                    b.ToTable("QLink");

                    b.HasData(
                        new
                        {
                            QNumber = "1",
                            QGroup = "1"
                        },
                        new
                        {
                            QNumber = "2",
                            QGroup = "1"
                        },
                        new
                        {
                            QNumber = "3",
                            QGroup = "1"
                        },
                        new
                        {
                            QNumber = "4",
                            QGroup = "1"
                        },
                        new
                        {
                            QNumber = "5",
                            QGroup = "2"
                        },
                        new
                        {
                            QNumber = "6",
                            QGroup = "2"
                        },
                        new
                        {
                            QNumber = "7",
                            QGroup = "2"
                        },
                        new
                        {
                            QNumber = "8",
                            QGroup = "3"
                        },
                        new
                        {
                            QNumber = "9",
                            QGroup = "3"
                        },
                        new
                        {
                            QNumber = "10",
                            QGroup = "4"
                        });
                });

            modelBuilder.Entity("EFCoreKeylessEntityTypes.Entities.SalesOrders", b =>
                {
                    b.Property<string>("SalesOrder")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("QLinkQNumber")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("QNumber")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("SalesOrder");

                    b.HasIndex("QLinkQNumber");

                    b.ToTable("SalesOrders");

                    b.HasData(
                        new
                        {
                            SalesOrder = "1",
                            QNumber = "1"
                        },
                        new
                        {
                            SalesOrder = "2",
                            QNumber = "1"
                        },
                        new
                        {
                            SalesOrder = "3",
                            QNumber = "2"
                        },
                        new
                        {
                            SalesOrder = "4",
                            QNumber = "2"
                        },
                        new
                        {
                            SalesOrder = "5",
                            QNumber = "3"
                        },
                        new
                        {
                            SalesOrder = "6",
                            QNumber = "3"
                        },
                        new
                        {
                            SalesOrder = "7",
                            QNumber = "4"
                        },
                        new
                        {
                            SalesOrder = "8",
                            QNumber = "4"
                        },
                        new
                        {
                            SalesOrder = "9",
                            QNumber = "5"
                        },
                        new
                        {
                            SalesOrder = "10",
                            QNumber = "6"
                        },
                        new
                        {
                            SalesOrder = "11",
                            QNumber = "6"
                        },
                        new
                        {
                            SalesOrder = "12",
                            QNumber = "6"
                        },
                        new
                        {
                            SalesOrder = "13",
                            QNumber = "7"
                        },
                        new
                        {
                            SalesOrder = "14",
                            QNumber = "7"
                        },
                        new
                        {
                            SalesOrder = "15",
                            QNumber = "8"
                        },
                        new
                        {
                            SalesOrder = "16",
                            QNumber = "8"
                        },
                        new
                        {
                            SalesOrder = "17",
                            QNumber = "9"
                        },
                        new
                        {
                            SalesOrder = "18",
                            QNumber = "9"
                        },
                        new
                        {
                            SalesOrder = "19",
                            QNumber = "10"
                        },
                        new
                        {
                            SalesOrder = "20",
                            QNumber = "10"
                        });
                });

            modelBuilder.Entity("EFCoreKeylessEntityTypes.Entities.SalesOrdersItems", b =>
                {
                    b.Property<string>("SalesOrderItem")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<decimal>("OrderQuantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PartNumber")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("SalesOrderID")
                        .HasColumnName("SalesOrder")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("UHeight")
                        .HasColumnType("int");

                    b.HasKey("SalesOrderItem");

                    b.HasIndex("SalesOrderID");

                    b.ToTable("SalesOrdersItems");

                    b.HasData(
                        new
                        {
                            SalesOrderItem = "1",
                            OrderQuantity = 10m,
                            PartNumber = "1",
                            SalesOrderID = "1",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "2",
                            OrderQuantity = 20m,
                            PartNumber = "2",
                            SalesOrderID = "1",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "3",
                            OrderQuantity = 40m,
                            PartNumber = "3",
                            SalesOrderID = "2",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "4",
                            OrderQuantity = 70m,
                            PartNumber = "1",
                            SalesOrderID = "3",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "5",
                            OrderQuantity = 40m,
                            PartNumber = "2",
                            SalesOrderID = "3",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "6",
                            OrderQuantity = 30m,
                            PartNumber = "2",
                            SalesOrderID = "4",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "7",
                            OrderQuantity = 40m,
                            PartNumber = "3",
                            SalesOrderID = "4",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "8",
                            OrderQuantity = 60m,
                            PartNumber = "2",
                            SalesOrderID = "5",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "9",
                            OrderQuantity = 50m,
                            PartNumber = "3",
                            SalesOrderID = "5",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "10",
                            OrderQuantity = 40m,
                            PartNumber = "4",
                            SalesOrderID = "5",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "11",
                            OrderQuantity = 40m,
                            PartNumber = "1",
                            SalesOrderID = "6",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "12",
                            OrderQuantity = 30m,
                            PartNumber = "2",
                            SalesOrderID = "7",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "13",
                            OrderQuantity = 20m,
                            PartNumber = "3",
                            SalesOrderID = "8",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "14",
                            OrderQuantity = 10m,
                            PartNumber = "4",
                            SalesOrderID = "9",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "15",
                            OrderQuantity = 60m,
                            PartNumber = "5",
                            SalesOrderID = "10",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "16",
                            OrderQuantity = 50m,
                            PartNumber = "2",
                            SalesOrderID = "11",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "17",
                            OrderQuantity = 40m,
                            PartNumber = "3",
                            SalesOrderID = "12",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "18",
                            OrderQuantity = 90m,
                            PartNumber = "1",
                            SalesOrderID = "12",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "19",
                            OrderQuantity = 80m,
                            PartNumber = "4",
                            SalesOrderID = "13",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "20",
                            OrderQuantity = 30m,
                            PartNumber = "2",
                            SalesOrderID = "14",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "21",
                            OrderQuantity = 20m,
                            PartNumber = "3",
                            SalesOrderID = "15",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "22",
                            OrderQuantity = 60m,
                            PartNumber = "4",
                            SalesOrderID = "16",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "23",
                            OrderQuantity = 80m,
                            PartNumber = "1",
                            SalesOrderID = "17",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "24",
                            OrderQuantity = 90m,
                            PartNumber = "1",
                            SalesOrderID = "18",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "25",
                            OrderQuantity = 100m,
                            PartNumber = "2",
                            SalesOrderID = "18",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "26",
                            OrderQuantity = 10m,
                            PartNumber = "2",
                            SalesOrderID = "19",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "27",
                            OrderQuantity = 20m,
                            PartNumber = "3",
                            SalesOrderID = "19",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "28",
                            OrderQuantity = 55m,
                            PartNumber = "4",
                            SalesOrderID = "19",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "29",
                            OrderQuantity = 78m,
                            PartNumber = "5",
                            SalesOrderID = "20",
                            UHeight = 0
                        },
                        new
                        {
                            SalesOrderItem = "30",
                            OrderQuantity = 45m,
                            PartNumber = "1",
                            SalesOrderID = "20",
                            UHeight = 0
                        });
                });

            modelBuilder.Entity("EFCoreKeylessEntityTypes.Entities.SalesOrders", b =>
                {
                    b.HasOne("EFCoreKeylessEntityTypes.Entities.QLink", "QLink")
                        .WithMany()
                        .HasForeignKey("QLinkQNumber");
                });

            modelBuilder.Entity("EFCoreKeylessEntityTypes.Entities.SalesOrdersItems", b =>
                {
                    b.HasOne("EFCoreKeylessEntityTypes.Entities.SalesOrders", "SalesOrder")
                        .WithMany("SalesOrdersItems")
                        .HasForeignKey("SalesOrderID");
                });
#pragma warning restore 612, 618
        }
    }
}
