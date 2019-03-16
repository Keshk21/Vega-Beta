using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class ChangeIdtoMakeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Makes",
                newName: "MakeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MakeId",
                table: "Makes",
                newName: "Id");
        }
    }
}
