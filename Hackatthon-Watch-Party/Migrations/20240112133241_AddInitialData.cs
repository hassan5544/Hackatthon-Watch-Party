using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackatthon_Watch_Party.Migrations
{
    public partial class AddInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Email", "Name", "PassWord" },
                values: new object[] { new Guid("b00b90ca-33df-422f-b010-1996b895631f"), "test", "test", "test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: new Guid("b00b90ca-33df-422f-b010-1996b895631f"));
        }
    }
}
