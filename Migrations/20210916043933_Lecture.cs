using Microsoft.EntityFrameworkCore.Migrations;

namespace Dotnet_Demo.Migrations
{
    public partial class Lecture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lecture",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    LectureName = table.Column<string>(type: "TEXT", nullable: true),
                    LectureHour = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecture", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lecture");
        }
    }
}
