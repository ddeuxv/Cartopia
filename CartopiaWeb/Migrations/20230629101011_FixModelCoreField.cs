using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CartopiaWeb.Migrations
{
    public partial class FixModelCoreField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoBinary",
                table: "Cars",
                newName: "Photo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "Cars",
                newName: "PhotoBinary");
        }
    }
}
