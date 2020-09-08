using Microsoft.EntityFrameworkCore.Migrations;

namespace GameCatalog.Migrations
{
    public partial class PlatformUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Platform_PlatformId",
                table: "Game");

            migrationBuilder.AlterColumn<int>(
                name: "PlatformId",
                table: "Game",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Platform_PlatformId",
                table: "Game",
                column: "PlatformId",
                principalTable: "Platform",
                principalColumn: "PlatformId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Platform_PlatformId",
                table: "Game");

            migrationBuilder.AlterColumn<int>(
                name: "PlatformId",
                table: "Game",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Platform_PlatformId",
                table: "Game",
                column: "PlatformId",
                principalTable: "Platform",
                principalColumn: "PlatformId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
