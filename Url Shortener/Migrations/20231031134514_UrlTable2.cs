using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Url_Shortener.Migrations
{
    /// <inheritdoc />
    public partial class UrlTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UrlLarga",
                table: "Urls",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "UrlCorta",
                table: "Urls",
                newName: "ShortUrl");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Urls",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "ContVisitas",
                table: "Urls",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContVisitas",
                table: "Urls");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Urls",
                newName: "UrlLarga");

            migrationBuilder.RenameColumn(
                name: "ShortUrl",
                table: "Urls",
                newName: "UrlCorta");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Urls",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);
        }
    }
}
