using Microsoft.EntityFrameworkCore.Migrations;

namespace BeltExam.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdeadId",
                table: "Ideas",
                newName: "IdeaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdeaId",
                table: "Ideas",
                newName: "IdeadId");
        }
    }
}
