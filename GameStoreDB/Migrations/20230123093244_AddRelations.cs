using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameStoreDB.Migrations
{
    /// <inheritdoc />
    public partial class AddRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hersteller",
                table: "Spiele");

            migrationBuilder.DropColumn(
                name: "Spieltyp",
                table: "Spiele");

            migrationBuilder.RenameColumn(
                name: "Spiel",
                table: "Lagerbestaende",
                newName: "SpielId");

            migrationBuilder.AddColumn<int>(
                name: "SpielId",
                table: "Spieltypen",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpielId",
                table: "Hersteller",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Spieltypen_SpielId",
                table: "Spieltypen",
                column: "SpielId");

            migrationBuilder.CreateIndex(
                name: "IX_Lagerbestaende_SpielId",
                table: "Lagerbestaende",
                column: "SpielId");

            migrationBuilder.CreateIndex(
                name: "IX_Hersteller_SpielId",
                table: "Hersteller",
                column: "SpielId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hersteller_Spiele_SpielId",
                table: "Hersteller",
                column: "SpielId",
                principalTable: "Spiele",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lagerbestaende_Spiele_SpielId",
                table: "Lagerbestaende",
                column: "SpielId",
                principalTable: "Spiele",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spieltypen_Spiele_SpielId",
                table: "Spieltypen",
                column: "SpielId",
                principalTable: "Spiele",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hersteller_Spiele_SpielId",
                table: "Hersteller");

            migrationBuilder.DropForeignKey(
                name: "FK_Lagerbestaende_Spiele_SpielId",
                table: "Lagerbestaende");

            migrationBuilder.DropForeignKey(
                name: "FK_Spieltypen_Spiele_SpielId",
                table: "Spieltypen");

            migrationBuilder.DropIndex(
                name: "IX_Spieltypen_SpielId",
                table: "Spieltypen");

            migrationBuilder.DropIndex(
                name: "IX_Lagerbestaende_SpielId",
                table: "Lagerbestaende");

            migrationBuilder.DropIndex(
                name: "IX_Hersteller_SpielId",
                table: "Hersteller");

            migrationBuilder.DropColumn(
                name: "SpielId",
                table: "Spieltypen");

            migrationBuilder.DropColumn(
                name: "SpielId",
                table: "Hersteller");

            migrationBuilder.RenameColumn(
                name: "SpielId",
                table: "Lagerbestaende",
                newName: "Spiel");

            migrationBuilder.AddColumn<int>(
                name: "Hersteller",
                table: "Spiele",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Spieltyp",
                table: "Spiele",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
