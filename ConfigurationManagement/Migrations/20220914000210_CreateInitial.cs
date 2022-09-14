using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConfigurationManagement.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConfigurationAlertes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationAlertes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ConfigurationCommerciales",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationCommerciales", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ConfigurationComptes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationComptes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ConfigurationPagePresentoires",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationPagePresentoires", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ConfigurationProfils",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationProfils", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ConfigurationPublicitees",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationPublicitees", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ConfigurationRecherches",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationRecherches", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Configurations",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConfigurationProfilID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConfigurationCommercialeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConfigurationPagePresentoireID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConfigurationCompteID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConfigurationAlertesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConfigurationPubliciteesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConfigurationRechercheID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configurations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Configurations_ConfigurationAlertes_ConfigurationAlertesID",
                        column: x => x.ConfigurationAlertesID,
                        principalTable: "ConfigurationAlertes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Configurations_ConfigurationCommerciales_ConfigurationCommercialeID",
                        column: x => x.ConfigurationCommercialeID,
                        principalTable: "ConfigurationCommerciales",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Configurations_ConfigurationComptes_ConfigurationCompteID",
                        column: x => x.ConfigurationCompteID,
                        principalTable: "ConfigurationComptes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Configurations_ConfigurationPagePresentoires_ConfigurationPagePresentoireID",
                        column: x => x.ConfigurationPagePresentoireID,
                        principalTable: "ConfigurationPagePresentoires",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Configurations_ConfigurationProfils_ConfigurationProfilID",
                        column: x => x.ConfigurationProfilID,
                        principalTable: "ConfigurationProfils",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Configurations_ConfigurationPublicitees_ConfigurationPubliciteesID",
                        column: x => x.ConfigurationPubliciteesID,
                        principalTable: "ConfigurationPublicitees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Configurations_ConfigurationRecherches_ConfigurationRechercheID",
                        column: x => x.ConfigurationRechercheID,
                        principalTable: "ConfigurationRecherches",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_ConfigurationAlertesID",
                table: "Configurations",
                column: "ConfigurationAlertesID");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_ConfigurationCommercialeID",
                table: "Configurations",
                column: "ConfigurationCommercialeID");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_ConfigurationCompteID",
                table: "Configurations",
                column: "ConfigurationCompteID");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_ConfigurationPagePresentoireID",
                table: "Configurations",
                column: "ConfigurationPagePresentoireID");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_ConfigurationProfilID",
                table: "Configurations",
                column: "ConfigurationProfilID");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_ConfigurationPubliciteesID",
                table: "Configurations",
                column: "ConfigurationPubliciteesID");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_ConfigurationRechercheID",
                table: "Configurations",
                column: "ConfigurationRechercheID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configurations");

            migrationBuilder.DropTable(
                name: "ConfigurationAlertes");

            migrationBuilder.DropTable(
                name: "ConfigurationCommerciales");

            migrationBuilder.DropTable(
                name: "ConfigurationComptes");

            migrationBuilder.DropTable(
                name: "ConfigurationPagePresentoires");

            migrationBuilder.DropTable(
                name: "ConfigurationProfils");

            migrationBuilder.DropTable(
                name: "ConfigurationPublicitees");

            migrationBuilder.DropTable(
                name: "ConfigurationRecherches");
        }
    }
}
