using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class FeatureTableSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Feature (FeatureName, ModelId) vALUES('Feature1-ModelA', 1)");
            migrationBuilder.Sql("INSERT INTO Feature (FeatureName, ModelId) vALUES('Feature1-ModelB', 1)");
            migrationBuilder.Sql("INSERT INTO Feature (FeatureName, ModelId) vALUES('Feature1-ModelC', 1)");

             migrationBuilder.Sql("INSERT INTO Feature (FeatureName, ModelId) vALUES('Feature2-ModelA', 2)");
            migrationBuilder.Sql("INSERT INTO Feature (FeatureName, ModelId) vALUES('Feature2-ModelB', 2)");
            migrationBuilder.Sql("INSERT INTO Feature (FeatureName, ModelId) vALUES('Feature2-ModelC', 2)");

            migrationBuilder.Sql("INSERT INTO Feature (FeatureName, ModelId) vALUES('Feature3-ModelA', 3)");
            migrationBuilder.Sql("INSERT INTO Feature (FeatureName, ModelId) vALUES('Feature3-ModelB', 3)");
            migrationBuilder.Sql("INSERT INTO Feature (FeatureName, ModelId) vALUES('Feature3-ModelC', 3)");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes");

        }
    }
}
