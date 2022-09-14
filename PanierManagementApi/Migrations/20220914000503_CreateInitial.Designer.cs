﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PanierManagementApi.Contexts;

#nullable disable

namespace PanierManagementApi.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20220914000503_CreateInitial")]
    partial class CreateInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PanierManagement.ListDeProduitsSelectionnes", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.ToTable("ListDeProduitsSelectionnes");
                });

            modelBuilder.Entity("PanierManagement.ListDeProduitsTotale", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.ToTable("ListDeProduitsTotale");
                });

            modelBuilder.Entity("PanierManagement.Panier", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ListDeProduitsSelectionnesID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ListDeProduitsTotaleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.HasIndex("ListDeProduitsSelectionnesID");

                    b.HasIndex("ListDeProduitsTotaleID");

                    b.ToTable("Paniers");
                });

            modelBuilder.Entity("PanierManagement.Panier", b =>
                {
                    b.HasOne("PanierManagement.ListDeProduitsSelectionnes", "ListDeProduitsSelectionnes")
                        .WithMany()
                        .HasForeignKey("ListDeProduitsSelectionnesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PanierManagement.ListDeProduitsTotale", "ListDeProduitsTotale")
                        .WithMany()
                        .HasForeignKey("ListDeProduitsTotaleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ListDeProduitsSelectionnes");

                    b.Navigation("ListDeProduitsTotale");
                });
#pragma warning restore 612, 618
        }
    }
}
