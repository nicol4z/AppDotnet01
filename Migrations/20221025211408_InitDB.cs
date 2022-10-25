using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppDotnet01.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materiales",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materiales", x => x.codigo);
                });

            migrationBuilder.CreateTable(
                name: "Proyectos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyectos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    IDTarea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    avance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDProyecto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.IDTarea);
                    table.ForeignKey(
                        name: "FK_Tareas_Proyectos_IDProyecto",
                        column: x => x.IDProyecto,
                        principalTable: "Proyectos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsumoMateriales",
                columns: table => new
                {
                    idConsumo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    IDTarea = table.Column<int>(type: "int", nullable: false),
                    IDMaterial = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumoMateriales", x => x.idConsumo);
                    table.ForeignKey(
                        name: "FK_ConsumoMateriales_Materiales_IDMaterial",
                        column: x => x.IDMaterial,
                        principalTable: "Materiales",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsumoMateriales_Tareas_IDTarea",
                        column: x => x.IDTarea,
                        principalTable: "Tareas",
                        principalColumn: "IDTarea",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConsumoMateriales_IDMaterial",
                table: "ConsumoMateriales",
                column: "IDMaterial");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumoMateriales_IDTarea",
                table: "ConsumoMateriales",
                column: "IDTarea");

            migrationBuilder.CreateIndex(
                name: "IX_Tareas_IDProyecto",
                table: "Tareas",
                column: "IDProyecto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsumoMateriales");

            migrationBuilder.DropTable(
                name: "Materiales");

            migrationBuilder.DropTable(
                name: "Tareas");

            migrationBuilder.DropTable(
                name: "Proyectos");
        }
    }
}
