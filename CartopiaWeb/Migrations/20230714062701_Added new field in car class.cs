using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CartopiaWeb.Migrations
{
    public partial class Addednewfieldincarclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2a967e2-feb0-4116-ab23-5f938fee19ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f60221be-3365-4410-a0fa-1f1826ddbbd5");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d22bb6f-3e96-45fb-88f5-663de35ee923", "da72fab9-1597-4bb8-8491-56221d7edc63", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f2ffa12-fe91-4941-8777-34d470799664", "2bfa2ff3-092f-469f-9e3b-8232a64f766d", "Admin", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d22bb6f-3e96-45fb-88f5-663de35ee923");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f2ffa12-fe91-4941-8777-34d470799664");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Cars");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a2a967e2-feb0-4116-ab23-5f938fee19ee", "046253ef-2b58-49ef-90f3-e6f9c08e8acb", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f60221be-3365-4410-a0fa-1f1826ddbbd5", "b53babf3-99be-4d59-8301-c81f313ec5ac", "Admin", "ADMINISTRATOR" });
        }
    }
}
