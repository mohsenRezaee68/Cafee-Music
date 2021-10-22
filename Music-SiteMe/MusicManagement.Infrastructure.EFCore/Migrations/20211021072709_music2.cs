using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicManagement.Infrastructure.EFCore.Migrations
{
    public partial class music2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CategoryId",
                table: "MusicTrack",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MusicTrack_CategoryId",
                table: "MusicTrack",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_MusicTrack_MusicCategories_CategoryId",
                table: "MusicTrack",
                column: "CategoryId",
                principalTable: "MusicCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MusicTrack_MusicCategories_CategoryId",
                table: "MusicTrack");

            migrationBuilder.DropIndex(
                name: "IX_MusicTrack_CategoryId",
                table: "MusicTrack");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "MusicTrack");
        }
    }
}
