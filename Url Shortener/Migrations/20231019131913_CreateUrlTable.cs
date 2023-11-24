using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Url_Shortener.Migrations
{
    /// <inheritdoc />
    public partial class CreateUrlTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Urls",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UrlLarga = table.Column<string>(type: "TEXT", nullable: false),
                    UrlCorta = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urls", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Urls");
        }
    }
}
