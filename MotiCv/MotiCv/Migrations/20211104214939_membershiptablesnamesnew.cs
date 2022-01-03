using Microsoft.EntityFrameworkCore.Migrations;

namespace MotiCv.Migrations
{
    public partial class membershiptablesnamesnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.EnsureSchema(
                name: "Membership");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "MotiUserTokens",
                newSchema: "Membership");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "MotiUsers",
                newSchema: "Membership");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "MotiUserRoles",
                newSchema: "Membership");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "MotiUserLogins",
                newSchema: "Membership");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "MotiUserClaims",
                newSchema: "Membership");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "MotiRoles",
                newSchema: "Membership");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "MotiRoleClaims",
                newSchema: "Membership");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "Membership",
                table: "MotiUserRoles",
                newName: "IX_MotiUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "Membership",
                table: "MotiUserLogins",
                newName: "IX_MotiUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "Membership",
                table: "MotiUserClaims",
                newName: "IX_MotiUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "Membership",
                table: "MotiRoleClaims",
                newName: "IX_MotiRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MotiUserTokens",
                schema: "Membership",
                table: "MotiUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MotiUsers",
                schema: "Membership",
                table: "MotiUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MotiUserRoles",
                schema: "Membership",
                table: "MotiUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MotiUserLogins",
                schema: "Membership",
                table: "MotiUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MotiUserClaims",
                schema: "Membership",
                table: "MotiUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MotiRoles",
                schema: "Membership",
                table: "MotiRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MotiRoleClaims",
                schema: "Membership",
                table: "MotiRoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MotiRoleClaims_MotiRoles_RoleId",
                schema: "Membership",
                table: "MotiRoleClaims",
                column: "RoleId",
                principalSchema: "Membership",
                principalTable: "MotiRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MotiUserClaims_MotiUsers_UserId",
                schema: "Membership",
                table: "MotiUserClaims",
                column: "UserId",
                principalSchema: "Membership",
                principalTable: "MotiUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MotiUserLogins_MotiUsers_UserId",
                schema: "Membership",
                table: "MotiUserLogins",
                column: "UserId",
                principalSchema: "Membership",
                principalTable: "MotiUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MotiUserRoles_MotiRoles_RoleId",
                schema: "Membership",
                table: "MotiUserRoles",
                column: "RoleId",
                principalSchema: "Membership",
                principalTable: "MotiRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MotiUserRoles_MotiUsers_UserId",
                schema: "Membership",
                table: "MotiUserRoles",
                column: "UserId",
                principalSchema: "Membership",
                principalTable: "MotiUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MotiUserTokens_MotiUsers_UserId",
                schema: "Membership",
                table: "MotiUserTokens",
                column: "UserId",
                principalSchema: "Membership",
                principalTable: "MotiUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MotiRoleClaims_MotiRoles_RoleId",
                schema: "Membership",
                table: "MotiRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_MotiUserClaims_MotiUsers_UserId",
                schema: "Membership",
                table: "MotiUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_MotiUserLogins_MotiUsers_UserId",
                schema: "Membership",
                table: "MotiUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_MotiUserRoles_MotiRoles_RoleId",
                schema: "Membership",
                table: "MotiUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_MotiUserRoles_MotiUsers_UserId",
                schema: "Membership",
                table: "MotiUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_MotiUserTokens_MotiUsers_UserId",
                schema: "Membership",
                table: "MotiUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MotiUserTokens",
                schema: "Membership",
                table: "MotiUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MotiUsers",
                schema: "Membership",
                table: "MotiUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MotiUserRoles",
                schema: "Membership",
                table: "MotiUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MotiUserLogins",
                schema: "Membership",
                table: "MotiUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MotiUserClaims",
                schema: "Membership",
                table: "MotiUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MotiRoles",
                schema: "Membership",
                table: "MotiRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MotiRoleClaims",
                schema: "Membership",
                table: "MotiRoleClaims");

            migrationBuilder.RenameTable(
                name: "MotiUserTokens",
                schema: "Membership",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "MotiUsers",
                schema: "Membership",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "MotiUserRoles",
                schema: "Membership",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "MotiUserLogins",
                schema: "Membership",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "MotiUserClaims",
                schema: "Membership",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "MotiRoles",
                schema: "Membership",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "MotiRoleClaims",
                schema: "Membership",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_MotiUserRoles_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_MotiUserLogins_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_MotiUserClaims_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_MotiRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
