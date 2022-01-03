using Microsoft.EntityFrameworkCore.Migrations;

namespace MotiCv.Migrations
{
    public partial class bestlongdescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BestLongDescription",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BestLongDescription",
                table: "Blogs");
        }
    }
}
