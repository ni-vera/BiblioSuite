using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Escritorio.Migrations
{
    /// <inheritdoc />
    public partial class nuevas_claves : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Obras",
                table: "Obras");

            migrationBuilder.AlterColumn<string>(
                name: "isbn",
                table: "Obras",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Obras",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Obras",
                table: "Obras",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Autors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    issn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    annus_natio = table.Column<int>(type: "int", nullable: false),
                    annus_defunctio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autors", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Obras",
                table: "Obras");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Obras");

            migrationBuilder.AlterColumn<string>(
                name: "isbn",
                table: "Obras",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Obras",
                table: "Obras",
                column: "isbn");
        }
    }
}
