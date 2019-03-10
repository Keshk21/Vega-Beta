using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class seedfeeature2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.Sql("INSERT INTO Features (FeatureName, ModelId) vALUES('Feature4-ModelA', 4)");
            migrationBuilder.Sql("INSERT INTO Features (FeatureName, ModelId) vALUES('Feature4-ModelB', 4)");
            migrationBuilder.Sql("INSERT INTO Features (FeatureName, ModelId) vALUES('Feature4-ModelC', 4)");

             migrationBuilder.Sql("INSERT INTO Features (FeatureName, ModelId) vALUES('Feature5-ModelA', 5)");
            migrationBuilder.Sql("INSERT INTO Features (FeatureName, ModelId) vALUES('Feature5-ModelB', 5)");
            migrationBuilder.Sql("INSERT INTO Features (FeatureName, ModelId) vALUES('Feature5-ModelC', 5)");

            migrationBuilder.Sql("INSERT INTO Features (FeatureName, ModelId) vALUES('Feature6-ModelA', 6)");
            migrationBuilder.Sql("INSERT INTO Features (FeatureName, ModelId) vALUES('Feature6-ModelB', 6)");
            migrationBuilder.Sql("INSERT INTO Features (FeatureName, ModelId) vALUES('Feature6-ModelC', 6)");

             migrationBuilder.Sql("INSERT INTO Features (FeatureName, ModelId) vALUES('Feature7-ModelA', 7)");
            migrationBuilder.Sql("INSERT INTO Features (FeatureName, ModelId) vALUES('Feature7-ModelB', 7)");
            migrationBuilder.Sql("INSERT INTO Features (FeatureName, ModelId) vALUES('Feature7-ModelC', 7)");

             migrationBuilder.Sql("INSERT INTO Features (FeatureName, ModelId) vALUES('Feature8-ModelA', 8)");
            migrationBuilder.Sql("INSERT INTO Features (FeatureName, ModelId) vALUES('Feature8-ModelB', 8)");
            migrationBuilder.Sql("INSERT INTO Features (FeatureName, ModelId) vALUES('Feature8-ModelC', 8)");

            migrationBuilder.Sql("INSERT INTO Features (FeatureName, ModelId) vALUES('Feature9-ModelA', 9)");
            migrationBuilder.Sql("INSERT INTO Features (FeatureName, ModelId) vALUES('Feature9-ModelB', 9)");
            migrationBuilder.Sql("INSERT INTO Features (FeatureName, ModelId) vALUES('Feature9-ModelC', 9)");
        
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes");

        }
    }
}
