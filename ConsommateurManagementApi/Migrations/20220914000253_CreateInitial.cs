using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsommateurManagementApi.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProduitsRecherches",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduitsRecherches", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StatisticConsommation",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatisticConsommation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Consommateurs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsommateurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatisticConsommationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProduitsRecherchesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModeDeLivraison = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consommateurs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Consommateurs_ProduitsRecherches_ProduitsRecherchesID",
                        column: x => x.ProduitsRecherchesID,
                        principalTable: "ProduitsRecherches",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consommateurs_StatisticConsommation_StatisticConsommationID",
                        column: x => x.StatisticConsommationID,
                        principalTable: "StatisticConsommation",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consommateurs_ProduitsRecherchesID",
                table: "Consommateurs",
                column: "ProduitsRecherchesID");

            migrationBuilder.CreateIndex(
                name: "IX_Consommateurs_StatisticConsommationID",
                table: "Consommateurs",
                column: "StatisticConsommationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consommateurs");

            migrationBuilder.DropTable(
                name: "ProduitsRecherches");

            migrationBuilder.DropTable(
                name: "StatisticConsommation");
        }
    }
}
