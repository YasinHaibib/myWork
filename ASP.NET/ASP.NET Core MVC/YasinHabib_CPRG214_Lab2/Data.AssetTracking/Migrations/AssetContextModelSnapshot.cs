﻿// <auto-generated />
using Data.AssetTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.AssetTracking.Migrations
{
    [DbContext(typeof(AssetContext))]
    partial class AssetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.AssetTracking.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssetTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TagNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssetTypeId");

                    b.ToTable("Asset");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AssetTypeId = 2,
                            Description = "4gb Ram, 1tb HD, Inten Core i5",
                            Manufacturer = "Acer",
                            Model = "446DSF68E4F",
                            SerialNumber = "SSN-D68F4EW",
                            TagNumber = "34A8"
                        },
                        new
                        {
                            Id = 2,
                            AssetTypeId = 1,
                            Description = "18inch Ultra HD monitor",
                            Manufacturer = "HP",
                            Model = "SF5E7F5E",
                            SerialNumber = "SSN-F4D8S6",
                            TagNumber = "894W"
                        },
                        new
                        {
                            Id = 3,
                            AssetTypeId = 3,
                            Description = "Just a phone...",
                            Manufacturer = "Cisco",
                            Model = "D4S6A84W",
                            SerialNumber = "SSN-SD6EF4",
                            TagNumber = "6D6A"
                        });
                });

            modelBuilder.Entity("Domain.AssetTracking.AssetType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AssetType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Computer manufacturers"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Monitors"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Phone"
                        });
                });

            modelBuilder.Entity("Domain.AssetTracking.Asset", b =>
                {
                    b.HasOne("Domain.AssetTracking.AssetType", "AssetsType")
                        .WithMany("Asset")
                        .HasForeignKey("AssetTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
