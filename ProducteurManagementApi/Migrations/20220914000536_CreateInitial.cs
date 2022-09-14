using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProducteurManagementApi.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PhotoProfiles",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoProfiles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Productions",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Producteurs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomDeFamille = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoProfileID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    ArticlesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producteurs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Producteurs_Articles_ArticlesID",
                        column: x => x.ArticlesID,
                        principalTable: "Articles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Producteurs_PhotoProfiles_PhotoProfileID",
                        column: x => x.PhotoProfileID,
                        principalTable: "PhotoProfiles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Producteurs_Productions_ProductionID",
                        column: x => x.ProductionID,
                        principalTable: "Productions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Producteurs_ArticlesID",
                table: "Producteurs",
                column: "ArticlesID");

            migrationBuilder.CreateIndex(
                name: "IX_Producteurs_PhotoProfileID",
                table: "Producteurs",
                column: "PhotoProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_Producteurs_ProductionID",
                table: "Producteurs",
                column: "ProductionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producteurs");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "PhotoProfiles");

            migrationBuilder.DropTable(
                name: "Productions");
        }
    }
}
