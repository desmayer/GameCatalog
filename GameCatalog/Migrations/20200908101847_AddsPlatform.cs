using Microsoft.EntityFrameworkCore.Migrations;

namespace GameCatalog.Migrations
{
    public partial class AddsPlatform : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Platform_PlatformId",
                table: "Game");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Platform",
                table: "Platform");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Platform");

            migrationBuilder.AddColumn<int>(
                name: "PlatformId",
                table: "Platform",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Platform",
                table: "Platform",
                column: "PlatformId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Platform_PlatformId",
                table: "Game",
                column: "PlatformId",
                principalTable: "Platform",
                principalColumn: "PlatformId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Platform_PlatformId",
                table: "Game");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Platform",
                table: "Platform");

            migrationBuilder.DropColumn(
                name: "PlatformId",
                table: "Platform");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Platform",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Platform",
                table: "Platform",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Platform_PlatformId",
                table: "Game",
                column: "PlatformId",
                principalTable: "Platform",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
