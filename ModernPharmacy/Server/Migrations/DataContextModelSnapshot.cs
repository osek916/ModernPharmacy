﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModernPharmacy.Server.Data;

#nullable disable

namespace ModernPharmacy.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DrugSubstance", b =>
                {
                    b.Property<int>("DrugsId")
                        .HasColumnType("int");

                    b.Property<int>("SubstancesId")
                        .HasColumnType("int");

                    b.HasKey("DrugsId", "SubstancesId");

                    b.HasIndex("SubstancesId");

                    b.ToTable("DrugSubstance");
                });

            modelBuilder.Entity("ModernPharmacy.Shared.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("ModernPharmacy.Shared.Drug", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LumpSumDrug")
                        .HasColumnType("bit");

                    b.Property<int?>("MilligramsPerTablets")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOfTablets")
                        .HasColumnType("int");

                    b.Property<bool>("PrescriptionRequired")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Drugs");
                });

            modelBuilder.Entity("ModernPharmacy.Shared.Pharmacy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasPrescriptionDrugs")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Pharmacies");
                });

            modelBuilder.Entity("ModernPharmacy.Shared.Substance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubstanceCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("SubstanceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubstanceCategoryId");

                    b.HasIndex("SubstanceId");

                    b.ToTable("Substances");
                });

            modelBuilder.Entity("ModernPharmacy.Shared.SubstanceCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SubstanceCategories");
                });

            modelBuilder.Entity("DrugSubstance", b =>
                {
                    b.HasOne("ModernPharmacy.Shared.Drug", null)
                        .WithMany()
                        .HasForeignKey("DrugsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModernPharmacy.Shared.Substance", null)
                        .WithMany()
                        .HasForeignKey("SubstancesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ModernPharmacy.Shared.Pharmacy", b =>
                {
                    b.HasOne("ModernPharmacy.Shared.Address", "Address")
                        .WithOne("Pharmacy")
                        .HasForeignKey("ModernPharmacy.Shared.Pharmacy", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("ModernPharmacy.Shared.Substance", b =>
                {
                    b.HasOne("ModernPharmacy.Shared.SubstanceCategory", null)
                        .WithMany("Substances")
                        .HasForeignKey("SubstanceCategoryId");

                    b.HasOne("ModernPharmacy.Shared.Substance", null)
                        .WithMany("Substances")
                        .HasForeignKey("SubstanceId");
                });

            modelBuilder.Entity("ModernPharmacy.Shared.Address", b =>
                {
                    b.Navigation("Pharmacy")
                        .IsRequired();
                });

            modelBuilder.Entity("ModernPharmacy.Shared.Substance", b =>
                {
                    b.Navigation("Substances");
                });

            modelBuilder.Entity("ModernPharmacy.Shared.SubstanceCategory", b =>
                {
                    b.Navigation("Substances");
                });
#pragma warning restore 612, 618
        }
    }
}
