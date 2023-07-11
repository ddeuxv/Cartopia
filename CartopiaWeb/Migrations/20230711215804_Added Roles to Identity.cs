using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CartopiaWeb.Migrations
{
    public partial class AddedRolestoIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04c61700-89a4-4832-9708-76068fa675f1", "40ff6045-1be0-41db-b931-dbc71902e23b", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "566ed264-b6c5-4a13-9bae-0607ad13c586", "f29e487a-6d46-4137-b540-53fef3c04050", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04c61700-89a4-4832-9708-76068fa675f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "566ed264-b6c5-4a13-9bae-0607ad13c586");
        }
    }
}
