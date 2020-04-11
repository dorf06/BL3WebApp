using Microsoft.EntityFrameworkCore.Migrations;

namespace BL3WebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Element = table.Column<string>(nullable: true),
                    WorldDrop = table.Column<string>(nullable: true),
                    DroppedBy = table.Column<string>(nullable: true),
                    QuestChallengeName = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    RedText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");
        }
    }
}
