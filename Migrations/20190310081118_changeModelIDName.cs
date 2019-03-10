using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class changeModelIDName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Models",
                newName: "ModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModelId",
                table: "Models",
                newName: "Id");
        }
    }
}
