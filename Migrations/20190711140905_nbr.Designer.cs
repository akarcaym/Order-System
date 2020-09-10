﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderManagement.Models;

namespace OrderManagement.Migrations
{
    [DbContext(typeof(SysContext))]
    [Migration("20190711140905_nbr")]
    partial class nbr
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("kopya.Models.Employee", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarChar(250)");

                    b.Property<string>("JTitle")
                        .IsRequired()
                        .HasColumnType("nvarChar(250)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarChar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarChar(250)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarChar(25)")
                        .HasMaxLength(10);

                    b.HasKey("ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("kopya.Models.Menu", b =>
                {
                    b.Property<int>("FID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FoodName");

                    b.Property<int>("Price");

                    b.Property<string>("Type");

                    b.HasKey("FID");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("kopya.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OrderName");

                    b.Property<int>("TableID");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}