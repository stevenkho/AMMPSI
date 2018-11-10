﻿// <auto-generated />
using AMMPSI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AMMPSI.Migrations
{
    [DbContext(typeof(AMContext))]
    partial class AMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AMMPSI.Models.Asset", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryID");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("DepreciationDuration");

                    b.Property<string>("Description");

                    b.Property<bool>("IsMoveable");

                    b.Property<string>("Name");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("Value");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Asset");
                });

            modelBuilder.Entity("AMMPSI.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("Name");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("AMMPSI.Models.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("ID");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("AMMPSI.Models.Movement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApprovedBy");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<string>("Description");

                    b.Property<int>("LocationID");

                    b.Property<DateTime>("MovementDate");

                    b.Property<string>("Status");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("ID");

                    b.HasIndex("LocationID");

                    b.ToTable("Movement");
                });

            modelBuilder.Entity("AMMPSI.Models.MovementItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssetID");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<bool>("IsMoved");

                    b.Property<int>("MovementID");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("ID");

                    b.HasIndex("AssetID");

                    b.HasIndex("MovementID");

                    b.ToTable("MovementItem");
                });

            modelBuilder.Entity("AMMPSI.Models.MovementLog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssetID");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<int>("LocationID");

                    b.Property<string>("MovedBy");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("ID");

                    b.HasIndex("AssetID");

                    b.HasIndex("LocationID");

                    b.ToTable("MovementLog");
                });

            modelBuilder.Entity("AMMPSI.Models.Asset", b =>
                {
                    b.HasOne("AMMPSI.Models.Category", "Category")
                        .WithMany("Asset")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AMMPSI.Models.Movement", b =>
                {
                    b.HasOne("AMMPSI.Models.Location", "Location")
                        .WithMany("Movement")
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AMMPSI.Models.MovementItem", b =>
                {
                    b.HasOne("AMMPSI.Models.Asset", "Asset")
                        .WithMany("MovementItem")
                        .HasForeignKey("AssetID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AMMPSI.Models.Movement", "Movement")
                        .WithMany("MovementItem")
                        .HasForeignKey("MovementID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AMMPSI.Models.MovementLog", b =>
                {
                    b.HasOne("AMMPSI.Models.Asset", "Asset")
                        .WithMany("MovementLog")
                        .HasForeignKey("AssetID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AMMPSI.Models.Location", "Location")
                        .WithMany("MovementLog")
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
