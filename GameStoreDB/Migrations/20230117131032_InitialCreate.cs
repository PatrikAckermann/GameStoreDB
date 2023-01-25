using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameStoreDB.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hersteller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hersteller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lagerbestaende",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Spiel = table.Column<int>(type: "int", nullable: false),
                    Zustand = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lagerbestaende", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spiele",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hersteller = table.Column<int>(type: "int", nullable: false),
                    Spieltyp = table.Column<int>(type: "int", nullable: false),
                    MinSpieler = table.Column<int>(type: "int", nullable: false),
                    MaxSpieler = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spiele", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spieltypen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Typ = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spieltypen", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hersteller");

            migrationBuilder.DropTable(
                name: "Lagerbestaende");

            migrationBuilder.DropTable(
                name: "Spiele");

            migrationBuilder.DropTable(
                name: "Spieltypen");
        }
    }
}
