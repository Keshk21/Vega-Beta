using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (MakeName) vALUES('Make1')");
            migrationBuilder.Sql("INSERT INTO Makes (MakeName) vALUES('Make2')");
            migrationBuilder.Sql("INSERT INTO Makes (MakeName) vALUES('Make3')");

            migrationBuilder.Sql("INSERT INTO Models (ModelName, MakeId) vALUES('Make1-ModelA', 1)");
            migrationBuilder.Sql("INSERT INTO Models (ModelName, MakeId) vALUES('Make1-ModelB', 1)");
            migrationBuilder.Sql("INSERT INTO Models (ModelName, MakeId) vALUES('Make1-ModelC', 1)");

             migrationBuilder.Sql("INSERT INTO Models (ModelName, MakeId) vALUES('Make2-ModelA', 2)");
            migrationBuilder.Sql("INSERT INTO Models (ModelName, MakeId) vALUES('Make2-ModelB', 2)");
            migrationBuilder.Sql("INSERT INTO Models (ModelName, MakeId) vALUES('Make2-ModelC', 2)");

            migrationBuilder.Sql("INSERT INTO Models (ModelName, MakeId) vALUES('Make3-ModelA', 3)");
            migrationBuilder.Sql("INSERT INTO Models (ModelName, MakeId) vALUES('Make3-ModelB', 3)");
            migrationBuilder.Sql("INSERT INTO Models (ModelName, MakeId) vALUES('Make3-ModelC', 3)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes");
        }
    }
}
