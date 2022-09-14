using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EtablissementManagementApi.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AlbumPhotos",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumPhotos", x => x.ID);
                });

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
                name: "CapaciteDeProductions",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TailleExploitation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaysRegionExploitation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NbLigneDeProduction = table.Column<int>(type: "int", nullable: false),
                    ContractProduction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChiffreAffaireAnnuel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapaciteDeProductions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CategoriesProduitsPrincipaux",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesProduitsPrincipaux", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CompetenceCommerciales",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LangueParlees = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QteEmployeDuDepartementVente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempsMoyenReponse = table.Column<int>(type: "int", nullable: false),
                    RevenueTotalAnnuel = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetenceCommerciales", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PresentationEquipes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresentationEquipes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PresentationProduction",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresentationProduction", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TermsAffaires",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DevisesAcceptees = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortLePlusProche = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TermsAffaires", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PresentationEtablissement",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeEtablissement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriesProduitsPrincipauxID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalRevenuAnnuel = table.Column<float>(type: "real", nullable: false),
                    Certification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrincipauxMarches = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaysRegion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreEmployes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDEtablissement = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CertificationDesProduits = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresentationEtablissement", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PresentationEtablissement_CategoriesProduitsPrincipaux_CategoriesProduitsPrincipauxID",
                        column: x => x.CategoriesProduitsPrincipauxID,
                        principalTable: "CategoriesProduitsPrincipaux",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfilCommercial",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompetenceCommercialeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TermsAffairesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfilCommercial", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProfilCommercial_CompetenceCommerciales_CompetenceCommercialeID",
                        column: x => x.CompetenceCommercialeID,
                        principalTable: "CompetenceCommerciales",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfilCommercial_TermsAffaires_TermsAffairesID",
                        column: x => x.TermsAffairesID,
                        principalTable: "TermsAffaires",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Etablissements",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdresseID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AlbumPhotosID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticlesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WebsiteAdresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PresentationProductionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PresentationEquipeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PresentationEtablissementID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapaciteDeProductionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfilCommercialID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etablissements", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Etablissements_Adresses_AdresseID",
                        column: x => x.AdresseID,
                        principalTable: "Adresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Etablissements_AlbumPhotos_AlbumPhotosID",
                        column: x => x.AlbumPhotosID,
                        principalTable: "AlbumPhotos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Etablissements_Articles_ArticlesID",
                        column: x => x.ArticlesID,
                        principalTable: "Articles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Etablissements_CapaciteDeProductions_CapaciteDeProductionID",
                        column: x => x.CapaciteDeProductionID,
                        principalTable: "CapaciteDeProductions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Etablissements_PresentationEquipes_PresentationEquipeID",
                        column: x => x.PresentationEquipeID,
                        principalTable: "PresentationEquipes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Etablissements_PresentationEtablissement_PresentationEtablissementID",
                        column: x => x.PresentationEtablissementID,
                        principalTable: "PresentationEtablissement",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Etablissements_PresentationProduction_PresentationProductionID",
                        column: x => x.PresentationProductionID,
                        principalTable: "PresentationProduction",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Etablissements_ProfilCommercial_ProfilCommercialID",
                        column: x => x.ProfilCommercialID,
                        principalTable: "ProfilCommercial",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Etablissements_AdresseID",
                table: "Etablissements",
                column: "AdresseID");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissements_AlbumPhotosID",
                table: "Etablissements",
                column: "AlbumPhotosID");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissements_ArticlesID",
                table: "Etablissements",
                column: "ArticlesID");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissements_CapaciteDeProductionID",
                table: "Etablissements",
                column: "CapaciteDeProductionID");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissements_PresentationEquipeID",
                table: "Etablissements",
                column: "PresentationEquipeID");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissements_PresentationEtablissementID",
                table: "Etablissements",
                column: "PresentationEtablissementID");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissements_PresentationProductionID",
                table: "Etablissements",
                column: "PresentationProductionID");

            migrationBuilder.CreateIndex(
                name: "IX_Etablissements_ProfilCommercialID",
                table: "Etablissements",
                column: "ProfilCommercialID");

            migrationBuilder.CreateIndex(
                name: "IX_PresentationEtablissement_CategoriesProduitsPrincipauxID",
                table: "PresentationEtablissement",
                column: "CategoriesProduitsPrincipauxID");

            migrationBuilder.CreateIndex(
                name: "IX_ProfilCommercial_CompetenceCommercialeID",
                table: "ProfilCommercial",
                column: "CompetenceCommercialeID");

            migrationBuilder.CreateIndex(
                name: "IX_ProfilCommercial_TermsAffairesID",
                table: "ProfilCommercial",
                column: "TermsAffairesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Etablissements");

            migrationBuilder.DropTable(
                name: "Adresses");

            migrationBuilder.DropTable(
                name: "AlbumPhotos");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "CapaciteDeProductions");

            migrationBuilder.DropTable(
                name: "PresentationEquipes");

            migrationBuilder.DropTable(
                name: "PresentationEtablissement");

            migrationBuilder.DropTable(
                name: "PresentationProduction");

            migrationBuilder.DropTable(
                name: "ProfilCommercial");

            migrationBuilder.DropTable(
                name: "CategoriesProduitsPrincipaux");

            migrationBuilder.DropTable(
                name: "CompetenceCommerciales");

            migrationBuilder.DropTable(
                name: "TermsAffaires");
        }
    }
}
