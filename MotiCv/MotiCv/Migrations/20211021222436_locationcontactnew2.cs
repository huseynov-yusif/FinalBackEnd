using Microsoft.EntityFrameworkCore.Migrations;

namespace MotiCv.Migrations
{
    public partial class locationcontactnew2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "description",
                table: "LocationContacts",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "LocationContacts",
                newName: "description");
        }
    }
}
