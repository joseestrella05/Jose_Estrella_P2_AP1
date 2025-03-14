﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jose_Estrella_P2_AP1.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    CiudadesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Monto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.CiudadesId);
                });

            migrationBuilder.CreateTable(
                name: "Encuestas",
                columns: table => new
                {
                    EncuestasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Asignatura = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encuestas", x => x.EncuestasId);
                });

            migrationBuilder.CreateTable(
                name: "Destalles",
                columns: table => new
                {
                    DestallesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EncuestaId = table.Column<int>(type: "int", nullable: false),
                    CiudadId = table.Column<int>(type: "int", nullable: false),
                    MontoEncuesta = table.Column<int>(type: "int", nullable: false),
                    EncuestasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destalles", x => x.DestallesId);
                    table.ForeignKey(
                        name: "FK_Destalles_Ciudades_CiudadId",
                        column: x => x.CiudadId,
                        principalTable: "Ciudades",
                        principalColumn: "CiudadesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Destalles_Encuestas_EncuestasId",
                        column: x => x.EncuestasId,
                        principalTable: "Encuestas",
                        principalColumn: "EncuestasId");
                });

            migrationBuilder.InsertData(
                table: "Ciudades",
                columns: new[] { "CiudadesId", "Monto", "Nombre" },
                values: new object[,]
                {
                    { 1, 0, "Santiago" },
                    { 2, 0, "Santo domingo" },
                    { 3, 0, "San Francisco de macoris" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Destalles_CiudadId",
                table: "Destalles",
                column: "CiudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Destalles_EncuestasId",
                table: "Destalles",
                column: "EncuestasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destalles");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "Encuestas");
        }
    }
}
