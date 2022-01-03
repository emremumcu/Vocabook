using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vocabook.AppData.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WordList",
                columns: table => new
                {
                    English = table.Column<string>(type: "TEXT", nullable: false),
                    Turkish = table.Column<string>(type: "TEXT", nullable: false),
                    Sample = table.Column<string>(type: "TEXT", nullable: true),
                    Synonym = table.Column<string>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "datetime('now', 'utc')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordList", x => x.English);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WordList");
        }
    }
}
