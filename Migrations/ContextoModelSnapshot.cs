﻿// <auto-generated />
using System;
using Jose_Estrella_P2_AP1.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jose_Estrella_P2_AP1.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

            modelBuilder.Entity("Jose_Estrella_P2_AP1.Models.Encuestas", b =>
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
#pragma warning restore 612, 618
        }
    }
}
