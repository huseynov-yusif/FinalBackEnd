using Microsoft.EntityFrameworkCore.Migrations;

namespace MotiCv.Migrations
{
    public partial class newnamecomments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Comments",
                newName: "AnsweredByUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnsweredByUserId",
                table: "Comments",
                newName: "MyProperty");
        }
    }
}
