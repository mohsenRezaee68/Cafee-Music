using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountMangement.Infrastructure.EFCore.Migrations
{
    public partial class ggghfr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MusicTrackUser_Accounts_TrackId",
                table: "MusicTrackUser");

            migrationBuilder.RenameColumn(
                name: "TrackId",
                table: "MusicTrackUser",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_MusicTrackUser_TrackId",
                table: "MusicTrackUser",
                newName: "IX_MusicTrackUser_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Sabk",
                table: "MusicTrackUser",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Keywords",
                table: "MusicTrackUser",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaDescription",
                table: "MusicTrackUser",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "MusicTrackUser",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MusicTrackUser_Accounts_UserId",
                table: "MusicTrackUser",
                column: "UserId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MusicTrackUser_Accounts_UserId",
                table: "MusicTrackUser");

            migrationBuilder.DropColumn(
                name: "Keywords",
                table: "MusicTrackUser");

            migrationBuilder.DropColumn(
                name: "MetaDescription",
                table: "MusicTrackUser");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "MusicTrackUser");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "MusicTrackUser",
                newName: "TrackId");

            migrationBuilder.RenameIndex(
                name: "IX_MusicTrackUser_UserId",
                table: "MusicTrackUser",
                newName: "IX_MusicTrackUser_TrackId");

            migrationBuilder.AlterColumn<string>(
                name: "Sabk",
                table: "MusicTrackUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MusicTrackUser_Accounts_TrackId",
                table: "MusicTrackUser",
                column: "TrackId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
