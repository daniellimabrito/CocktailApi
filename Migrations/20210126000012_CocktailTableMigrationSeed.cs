using Microsoft.EntityFrameworkCore.Migrations;

namespace CocktailApi.Migrations
{
    public partial class CocktailTableMigrationSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cocktails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "varchar", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "varchar", maxLength: 400, nullable: true),
                    Type = table.Column<string>(type: "varchar", maxLength: 50, nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cocktails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cocktails");
        }
    }
}
