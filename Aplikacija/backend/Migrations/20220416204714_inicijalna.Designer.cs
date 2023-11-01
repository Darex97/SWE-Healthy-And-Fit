﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace Aplikacija_swe.Migrations
{
    [DbContext(typeof(SajtContext))]
    [Migration("20220416204714_inicijalna")]
    partial class inicijalna
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KorisnikPlan", b =>
                {
                    b.Property<int>("KorisniciPlanoviID")
                        .HasColumnType("int");

                    b.Property<int>("PlanoviKorisniciID")
                        .HasColumnType("int");

                    b.HasKey("KorisniciPlanoviID", "PlanoviKorisniciID");

                    b.HasIndex("PlanoviKorisniciID");

                    b.ToTable("KorisnikPlan");
                });

            modelBuilder.Entity("Models.Administrator", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdminSajtID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sifra")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("AdminSajtID");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DatumRodjenja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("KolicinaNovca")
                        .HasColumnType("int");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("KorisnikSajtID")
                        .HasColumnType("int");

                    b.Property<string>("Pol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sifra")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikSajtID");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("Models.Plan", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cena")
                        .HasColumnType("int");

                    b.Property<string>("NazivPlana")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oblast")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlanStrucnjakID")
                        .HasColumnType("int");

                    b.Property<int?>("SajtID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PlanStrucnjakID");

                    b.HasIndex("SajtID");

                    b.ToTable("Plan");
                });

            modelBuilder.Entity("Models.Sajt", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsloviIPravilaKoriscenja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Sajt");
                });

            modelBuilder.Entity("Models.StrucnoLice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DatumRodjenja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("KolicinaNovca")
                        .HasColumnType("int");

                    b.Property<string>("Komentari")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OblastStruke")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Obrazovanje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OdobrenjeAdmina")
                        .HasColumnType("bit");

                    b.Property<string>("Pol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProsecnaOcena")
                        .HasColumnType("int");

                    b.Property<string>("Sifra")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("StrucnjakSajtID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("StrucnjakSajtID");

                    b.ToTable("StrucnoLice");
                });

            modelBuilder.Entity("KorisnikPlan", b =>
                {
                    b.HasOne("Models.Plan", null)
                        .WithMany()
                        .HasForeignKey("KorisniciPlanoviID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("PlanoviKorisniciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Administrator", b =>
                {
                    b.HasOne("Models.Sajt", "AdminSajt")
                        .WithMany("Admini")
                        .HasForeignKey("AdminSajtID");

                    b.Navigation("AdminSajt");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.HasOne("Models.Sajt", "KorisnikSajt")
                        .WithMany("Korisnici")
                        .HasForeignKey("KorisnikSajtID");

                    b.Navigation("KorisnikSajt");
                });

            modelBuilder.Entity("Models.Plan", b =>
                {
                    b.HasOne("Models.StrucnoLice", "PlanStrucnjak")
                        .WithMany("StrucnaLicaPlanovi")
                        .HasForeignKey("PlanStrucnjakID");

                    b.HasOne("Models.Sajt", null)
                        .WithMany("Planovi")
                        .HasForeignKey("SajtID");

                    b.Navigation("PlanStrucnjak");
                });

            modelBuilder.Entity("Models.StrucnoLice", b =>
                {
                    b.HasOne("Models.Sajt", "StrucnjakSajt")
                        .WithMany("StrucnaLica")
                        .HasForeignKey("StrucnjakSajtID");

                    b.Navigation("StrucnjakSajt");
                });

            modelBuilder.Entity("Models.Sajt", b =>
                {
                    b.Navigation("Admini");

                    b.Navigation("Korisnici");

                    b.Navigation("Planovi");

                    b.Navigation("StrucnaLica");
                });

            modelBuilder.Entity("Models.StrucnoLice", b =>
                {
                    b.Navigation("StrucnaLicaPlanovi");
                });
#pragma warning restore 612, 618
        }
    }
}
