using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackatthon_Watch.Migrations
{
    public partial class WatchPartyEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Thumbnailurl",
                table: "Videos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "WatchParties",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Videoid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchParties", x => x.id);
                    table.ForeignKey(
                        name: "FK_WatchParties_Videos_Videoid",
                        column: x => x.Videoid,
                        principalTable: "Videos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WatchParties_Videoid",
                table: "WatchParties",
                column: "Videoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WatchParties");

            migrationBuilder.DropColumn(
                name: "Thumbnailurl",
                table: "Videos");
        }
    }
}
