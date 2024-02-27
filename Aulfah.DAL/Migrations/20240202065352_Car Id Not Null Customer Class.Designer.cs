﻿// <auto-generated />
using System;
using Aulfah.DataContex;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Aulfah.DAL.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240202065352_Car Id Not Null Customer Class")]
    partial class CarIdNotNullCustomerClass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ArtistService", b =>
                {
                    b.Property<int>("ArtistsArtistID")
                        .HasColumnType("int");

                    b.Property<int>("ServiceID")
                        .HasColumnType("int");

                    b.HasKey("ArtistsArtistID", "ServiceID");

                    b.HasIndex("ServiceID");

                    b.ToTable("ArtistService");
                });

            modelBuilder.Entity("Aulfah.DAL.Model.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Aulfah.Models.Artist", b =>
                {
                    b.Property<int>("ArtistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistID"), 1L, 1);

                    b.Property<string>("CardDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CardNum")
                        .HasColumnType("int");

                    b.Property<string>("Courses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Goverment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SecurityKey")
                        .HasColumnType("int");

                    b.Property<string>("ServicesType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("socialMedia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistID");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("Aulfah.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"), 1L, 1);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double?>("totalPrice")
                        .HasColumnType("float");

                    b.HasKey("CartId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("Aulfah.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<string>("CardDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CardNum")
                        .HasColumnType("int");

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Goverment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SecurityKey")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateOfBirth")
                        .HasColumnType("datetime2");

                    b.HasKey("CustomerId");

                    b.HasIndex("CartId")
                        .IsUnique();

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Aulfah.Models.Orders", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"), 1L, 1);

                    b.Property<int?>("CartID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PaymentID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("ServiceID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("ShipmentID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("TrackID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("dateCraeted")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderID");

                    b.HasIndex("CartID");

                    b.HasIndex("PaymentID");

                    b.HasIndex("ServiceID");

                    b.HasIndex("ShipmentID");

                    b.HasIndex("TrackID")
                        .IsUnique();

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Aulfah.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Aulfah.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int?>("ArtistID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("float");

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("ArtistID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Aulfah.Models.Service", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrdersID")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ServiceID");

                    b.HasIndex("OrdersID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Aulfah.Models.Shipment", b =>
                {
                    b.Property<int>("ShipmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShipmentID"), 1L, 1);

                    b.Property<string>("Totalsize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShipmentID");

                    b.ToTable("Shipments");
                });

            modelBuilder.Entity("Aulfah.Models.Tracking", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrackId"), 1L, 1);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrackId");

                    b.ToTable("Track");
                });

            modelBuilder.Entity("CartProduct", b =>
                {
                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsProductId")
                        .HasColumnType("int");

                    b.HasKey("CartId", "ProductsProductId");

                    b.HasIndex("ProductsProductId");

                    b.ToTable("CartProduct");
                });

            modelBuilder.Entity("CustomerService", b =>
                {
                    b.Property<int>("CustomersCustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceID")
                        .HasColumnType("int");

                    b.HasKey("CustomersCustomerId", "ServiceID");

                    b.HasIndex("ServiceID");

                    b.ToTable("CustomerService");
                });

            modelBuilder.Entity("ArtistService", b =>
                {
                    b.HasOne("Aulfah.Models.Artist", null)
                        .WithMany()
                        .HasForeignKey("ArtistsArtistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aulfah.Models.Service", null)
                        .WithMany()
                        .HasForeignKey("ServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aulfah.Models.Customer", b =>
                {
                    b.HasOne("Aulfah.Models.Cart", "Cart")
                        .WithOne("Customers")
                        .HasForeignKey("Aulfah.Models.Customer", "CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");
                });

            modelBuilder.Entity("Aulfah.Models.Orders", b =>
                {
                    b.HasOne("Aulfah.Models.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aulfah.Models.Payment", "Payment")
                        .WithMany("Orders")
                        .HasForeignKey("PaymentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aulfah.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aulfah.Models.Shipment", "Shipment")
                        .WithMany("Orders")
                        .HasForeignKey("ShipmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aulfah.Models.Tracking", "Track")
                        .WithOne("Orders")
                        .HasForeignKey("Aulfah.Models.Orders", "TrackID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Payment");

                    b.Navigation("Service");

                    b.Navigation("Shipment");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Aulfah.Models.Product", b =>
                {
                    b.HasOne("Aulfah.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("Aulfah.Models.Service", b =>
                {
                    b.HasOne("Aulfah.Models.Orders", "Orders")
                        .WithMany()
                        .HasForeignKey("OrdersID");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("CartProduct", b =>
                {
                    b.HasOne("Aulfah.Models.Cart", null)
                        .WithMany()
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aulfah.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerService", b =>
                {
                    b.HasOne("Aulfah.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aulfah.Models.Service", null)
                        .WithMany()
                        .HasForeignKey("ServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Aulfah.Models.Cart", b =>
                {
                    b.Navigation("Customers")
                        .IsRequired();
                });

            modelBuilder.Entity("Aulfah.Models.Payment", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Aulfah.Models.Shipment", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Aulfah.Models.Tracking", b =>
                {
                    b.Navigation("Orders")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
