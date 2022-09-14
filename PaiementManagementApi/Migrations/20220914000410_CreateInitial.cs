using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaiementManagementApi.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountReceiver",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountReceiver", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AccountSender",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountSender", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Paiements",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusPaiement = table.Column<int>(type: "int", nullable: false),
                    AccountSenderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountReceiverID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaiementMethod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paiements", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Paiements_AccountReceiver_AccountReceiverID",
                        column: x => x.AccountReceiverID,
                        principalTable: "AccountReceiver",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Paiements_AccountSender_AccountSenderID",
                        column: x => x.AccountSenderID,
                        principalTable: "AccountSender",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paiements_AccountReceiverID",
                table: "Paiements",
                column: "AccountReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_Paiements_AccountSenderID",
                table: "Paiements",
                column: "AccountSenderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paiements");

            migrationBuilder.DropTable(
                name: "AccountReceiver");

            migrationBuilder.DropTable(
                name: "AccountSender");
        }
    }
}
