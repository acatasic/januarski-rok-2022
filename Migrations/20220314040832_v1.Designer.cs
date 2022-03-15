﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using zoo.Models;

namespace zoo.Migrations
{
    [DbContext(typeof(zooContext))]
    [Migration("20220314040832_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("KategorijaProdukcijskaKuca", b =>
                {
                    b.Property<int>("KategorijaID")
                        .HasColumnType("int");

                    b.Property<int>("ProdukcijskaKucaID")
                        .HasColumnType("int");

                    b.HasKey("KategorijaID", "ProdukcijskaKucaID");

                    b.HasIndex("ProdukcijskaKucaID");

                    b.ToTable("KategorijaProdukcijskaKuca");
                });

            modelBuilder.Entity("zoo.Models.Film", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<int>("BrojOcena")
                        .HasColumnType("int")
                        .HasColumnName("BrojOcena");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ime");

                    b.Property<int?>("KategorijaID")
                        .HasColumnType("int");

                    b.Property<float>("Ocena")
                        .HasColumnType("real")
                        .HasColumnName("Ocena");

                    b.Property<int?>("ProdukcijskaKucaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KategorijaID");

                    b.HasIndex("ProdukcijskaKucaID");

                    b.ToTable("Film");
                });

            modelBuilder.Entity("zoo.Models.Kategorija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<string>("Tip")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Tip");

                    b.HasKey("ID");

                    b.ToTable("Kategorija");
                });

            modelBuilder.Entity("zoo.Models.ProdukcijskaKuca", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Naziv");

                    b.HasKey("ID");

                    b.ToTable("ProdKuca");
                });

            modelBuilder.Entity("KategorijaProdukcijskaKuca", b =>
                {
                    b.HasOne("zoo.Models.Kategorija", null)
                        .WithMany()
                        .HasForeignKey("KategorijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("zoo.Models.ProdukcijskaKuca", null)
                        .WithMany()
                        .HasForeignKey("ProdukcijskaKucaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("zoo.Models.Film", b =>
                {
                    b.HasOne("zoo.Models.Kategorija", "Kategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaID");

                    b.HasOne("zoo.Models.ProdukcijskaKuca", "ProdukcijskaKuca")
                        .WithMany()
                        .HasForeignKey("ProdukcijskaKucaID");

                    b.Navigation("Kategorija");

                    b.Navigation("ProdukcijskaKuca");
                });
#pragma warning restore 612, 618
        }
    }
}
