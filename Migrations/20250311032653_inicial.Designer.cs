﻿// <auto-generated />
using System;
using Jose_Estrella_P2_AP1.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jose_Estrella_P2_AP1.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20250311032653_inicial")]
    partial class inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Encuestas", b =>
                {
                    b.Property<int>("EncuestasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EncuestasId"));

                    b.Property<string>("Asignatura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("EncuestasId");

                    b.ToTable("Encuestas");
                });

            modelBuilder.Entity("Jose_Estrella_P2_AP1.Models.Ciudades", b =>
                {
                    b.Property<int>("CiudadesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CiudadesId"));

                    b.Property<int>("Monto")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CiudadesId");

                    b.ToTable("Ciudades");

                    b.HasData(
                        new
                        {
                            CiudadesId = 1,
                            Monto = 0,
                            Nombre = "Santiago"
                        },
                        new
                        {
                            CiudadesId = 2,
                            Monto = 0,
                            Nombre = "Santo domingo"
                        },
                        new
                        {
                            CiudadesId = 3,
                            Monto = 0,
                            Nombre = "San Francisco de macoris"
                        });
                });

            modelBuilder.Entity("Jose_Estrella_P2_AP1.Models.EncuestaDestalles", b =>
                {
                    b.Property<int>("DestallesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DestallesId"));

                    b.Property<int>("CiudadId")
                        .HasColumnType("int");

                    b.Property<int>("EncuestaId")
                        .HasColumnType("int");

                    b.Property<int?>("EncuestasId")
                        .HasColumnType("int");

                    b.Property<int>("MontoEncuesta")
                        .HasColumnType("int");

                    b.HasKey("DestallesId");

                    b.HasIndex("CiudadId");

                    b.HasIndex("EncuestasId");

                    b.ToTable("Destalles");
                });

            modelBuilder.Entity("Jose_Estrella_P2_AP1.Models.EncuestaDestalles", b =>
                {
                    b.HasOne("Jose_Estrella_P2_AP1.Models.Ciudades", "Ciudad")
                        .WithMany()
                        .HasForeignKey("CiudadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Encuestas", null)
                        .WithMany("EncuestaDetalles")
                        .HasForeignKey("EncuestasId");

                    b.Navigation("Ciudad");
                });

            modelBuilder.Entity("Encuestas", b =>
                {
                    b.Navigation("EncuestaDetalles");
                });
#pragma warning restore 612, 618
        }
    }
}
