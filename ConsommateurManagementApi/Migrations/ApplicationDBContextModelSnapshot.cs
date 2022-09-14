﻿// <auto-generated />
using System;
using ConsommateurManagementApi.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsommateurManagementApi.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ConsommateurManagement.Consommateur", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConsommateurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModeDeLivraison")
                        .HasColumnType("int");

                    b.Property<Guid>("ProduitsRecherchesID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StatisticConsommationID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("ProduitsRecherchesID");

                    b.HasIndex("StatisticConsommationID");

                    b.ToTable("Consommateurs");
                });

            modelBuilder.Entity("ConsommateurManagement.ProduitsRecherches", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.ToTable("ProduitsRecherches");
                });

            modelBuilder.Entity("ConsommateurManagement.StatisticConsommation", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.ToTable("StatisticConsommation");
                });

            modelBuilder.Entity("ConsommateurManagement.Consommateur", b =>
                {
                    b.HasOne("ConsommateurManagement.ProduitsRecherches", "ProduitsRecherches")
                        .WithMany()
                        .HasForeignKey("ProduitsRecherchesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsommateurManagement.StatisticConsommation", "StatisticConsommation")
                        .WithMany()
                        .HasForeignKey("StatisticConsommationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProduitsRecherches");

                    b.Navigation("StatisticConsommation");
                });
#pragma warning restore 612, 618
        }
    }
}
