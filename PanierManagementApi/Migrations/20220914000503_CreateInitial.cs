using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PanierManagementApi.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListDeProduitsSelectionnes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListDeProduitsSelectionnes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ListDeProduitsTotale",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListDeProduitsTotale", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Paniers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Total = table.Column<float>(type: "real", nullable: false),
                    ListDeProduitsSelectionnesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ListDeProduitsTotaleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paniers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Paniers_ListDeProduitsSelectionnes_ListDeProduitsSelectionnesID",
                        column: x => x.ListDeProduitsSelectionnesID,
                        principalTable: "ListDeProduitsSelectionnes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Paniers_ListDeProduitsTotale_ListDeProduitsTotaleID",
                        column: x => x.ListDeProduitsTotaleID,
                        principalTable: "ListDeProduitsTotale",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paniers_ListDeProduitsSelectionnesID",
                table: "Paniers",
                column: "ListDeProduitsSelectionnesID");

            migrationBuilder.CreateIndex(
                name: "IX_Paniers_ListDeProduitsTotaleID",
                table: "Paniers",
                column: "ListDeProduitsTotaleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paniers");

            migrationBuilder.DropTable(
                name: "ListDeProduitsSelectionnes");

            migrationBuilder.DropTable(
                name: "ListDeProduitsTotale");
        }
    }
}
