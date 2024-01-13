using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackatthon_Watch_Party.Migrations
{
    public partial class AddRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1360fbbe-f048-4638-837c-ef08cede3af0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "963e03cf-a915-4c8d-bea6-01043d5f9bb2", "275a79cb-491b-4ffe-8605-b4f5790e3f0f", "User", "User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "963e03cf-a915-4c8d-bea6-01043d5f9bb2");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PassWord", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1360fbbe-f048-4638-837c-ef08cede3af0", 0, "36ce9e91-d49e-49f6-843c-1d0e2b711683", "User", "test", false, false, null, "test", null, null, "test", null, null, false, "2ec3361c-3d63-4982-b4b9-bbe13dd3e2e6", false, null });
        }
    }
}
