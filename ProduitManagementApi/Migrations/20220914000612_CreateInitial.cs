using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProduitManagementApi.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FAQs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductPhotos",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPhotos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProduitAvantages",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduitAvantages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProduitCertifications",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduitCertifications", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProduitDescriptions",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduitDescriptions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProduitExpositions",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduitExpositions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProduitLivraisons",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduitLivraisons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantite = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinPrice = table.Column<float>(type: "real", nullable: false),
                    MaxPrice = table.Column<float>(type: "real", nullable: false),
                    Reduction = table.Column<float>(type: "real", nullable: false),
                    ProductPhotosID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoriesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProduitDescriptionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AvantagesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CertificationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExpositionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProduitLivraisonID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FaqID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Produits_Categories_CategoriesID",
                        column: x => x.CategoriesID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produits_FAQs_FaqID",
                        column: x => x.FaqID,
                        principalTable: "FAQs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produits_ProductPhotos_ProductPhotosID",
                        column: x => x.ProductPhotosID,
                        principalTable: "ProductPhotos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produits_ProduitAvantages_AvantagesID",
                        column: x => x.AvantagesID,
                        principalTable: "ProduitAvantages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produits_ProduitCertifications_CertificationID",
                        column: x => x.CertificationID,
                        principalTable: "ProduitCertifications",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produits_ProduitDescriptions_ProduitDescriptionID",
                        column: x => x.ProduitDescriptionID,
                        principalTable: "ProduitDescriptions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produits_ProduitExpositions_ExpositionID",
                        column: x => x.ExpositionID,
                        principalTable: "ProduitExpositions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produits_ProduitLivraisons_ProduitLivraisonID",
                        column: x => x.ProduitLivraisonID,
                        principalTable: "ProduitLivraisons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produits_AvantagesID",
                table: "Produits",
                column: "AvantagesID");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_CategoriesID",
                table: "Produits",
                column: "CategoriesID");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_CertificationID",
                table: "Produits",
                column: "CertificationID");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_ExpositionID",
                table: "Produits",
                column: "ExpositionID");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_FaqID",
                table: "Produits",
                column: "FaqID");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_ProductPhotosID",
                table: "Produits",
                column: "ProductPhotosID");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_ProduitDescriptionID",
                table: "Produits",
                column: "ProduitDescriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_ProduitLivraisonID",
                table: "Produits",
                column: "ProduitLivraisonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produits");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "FAQs");

            migrationBuilder.DropTable(
                name: "ProductPhotos");

            migrationBuilder.DropTable(
                name: "ProduitAvantages");

            migrationBuilder.DropTable(
                name: "ProduitCertifications");

            migrationBuilder.DropTable(
                name: "ProduitDescriptions");

            migrationBuilder.DropTable(
                name: "ProduitExpositions");

            migrationBuilder.DropTable(
                name: "ProduitLivraisons");
        }
    }
}
