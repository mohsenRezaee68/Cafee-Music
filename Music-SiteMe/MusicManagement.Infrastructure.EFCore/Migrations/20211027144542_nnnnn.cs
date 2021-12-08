using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicManagement.Infrastructure.EFCore.Migrations
{
    public partial class nnnnn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MusicCategories_MusicCategories_MusicCategoryId",
                table: "MusicCategories");

            migrationBuilder.DropIndex(
                name: "IX_MusicCategories_MusicCategoryId",
                table: "MusicCategories");

            migrationBuilder.DropColumn(
                name: "MusicCategoryId",
                table: "MusicCategories");

            migrationBuilder.AddColumn<string>(
                name: "TrackName",
                table: "MusicTrack",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrackName",
                table: "MusicTrack");

            migrationBuilder.AddColumn<long>(
                name: "MusicCategoryId",
                table: "MusicCategories",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MusicCategories_MusicCategoryId",
                table: "MusicCategories",
                column: "MusicCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_MusicCategories_MusicCategories_MusicCategoryId",
                table: "MusicCategories",
                column: "MusicCategoryId",
                principalTable: "MusicCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
