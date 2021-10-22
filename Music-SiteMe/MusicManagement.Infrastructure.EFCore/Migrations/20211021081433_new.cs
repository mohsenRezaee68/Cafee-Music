using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicManagement.Infrastructure.EFCore.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Musics");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Code",
                table: "Musics",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");
        }
    }
}
