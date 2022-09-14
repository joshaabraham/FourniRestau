using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbonnementManagementAPI.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abonnements",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AbonnementName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PeriodePaiement = table.Column<int>(type: "int", nullable: false),
                    PeriodeLivraison = table.Column<int>(type: "int", nullable: false),
                    RepetitionAutomatique = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abonnements", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abonnements");
        }
    }
}
