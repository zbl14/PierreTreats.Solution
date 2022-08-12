﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PierreTreats.Models;

namespace PierreTreats.Migrations
{
    [DbContext(typeof(PierreTreatsContext))]
    partial class PierreTreatsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("PierreTreats.Models.Flavor", b =>
                {
                    b.Property<int>("FlavorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("FlavorId");

                    b.ToTable("Flavors");
                });

            modelBuilder.Entity("PierreTreats.Models.Treat", b =>
                {
                    b.Property<int>("TreatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("TreatId");

                    b.ToTable("Treats");
                });

            modelBuilder.Entity("PierreTreats.Models.TreatFlavor", b =>
                {
                    b.Property<int>("TreatFlavorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FlavorId")
                        .HasColumnType("int");

                    b.Property<int>("TreatId")
                        .HasColumnType("int");

                    b.HasKey("TreatFlavorId");

                    b.HasIndex("FlavorId");

                    b.HasIndex("TreatId");

                    b.ToTable("TreatFlavor");
                });

            modelBuilder.Entity("PierreTreats.Models.TreatFlavor", b =>
                {
                    b.HasOne("PierreTreats.Models.Flavor", "Flavor")
                        .WithMany("TreatFlavors")
                        .HasForeignKey("FlavorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PierreTreats.Models.Treat", "Treat")
                        .WithMany("TreatFlavors")
                        .HasForeignKey("TreatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flavor");

                    b.Navigation("Treat");
                });

            modelBuilder.Entity("PierreTreats.Models.Flavor", b =>
                {
                    b.Navigation("TreatFlavors");
                });

            modelBuilder.Entity("PierreTreats.Models.Treat", b =>
                {
                    b.Navigation("TreatFlavors");
                });
#pragma warning restore 612, 618
        }
    }
}