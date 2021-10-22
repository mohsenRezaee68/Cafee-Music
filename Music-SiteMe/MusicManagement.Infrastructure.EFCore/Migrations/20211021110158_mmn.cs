using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicManagement.Infrastructure.EFCore.Migrations
{
    public partial class mmn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MusicTrack_Musics_MusicId",
                table: "MusicTrack");

            migrationBuilder.RenameColumn(
                name: "MusicId",
                table: "MusicTrack",
                newName: "TrackId");

            migrationBuilder.RenameIndex(
                name: "IX_MusicTrack_MusicId",
                table: "MusicTrack",
                newName: "IX_MusicTrack_TrackId");

            migrationBuilder.AddForeignKey(
                name: "FK_MusicTrack_Musics_TrackId",
                table: "MusicTrack",
                column: "TrackId",
                principalTable: "Musics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MusicTrack_Musics_TrackId",
                table: "MusicTrack");

            migrationBuilder.RenameColumn(
                name: "TrackId",
                table: "MusicTrack",
                newName: "MusicId");

            migrationBuilder.RenameIndex(
                name: "IX_MusicTrack_TrackId",
                table: "MusicTrack",
                newName: "IX_MusicTrack_MusicId");

            migrationBuilder.AddForeignKey(
                name: "FK_MusicTrack_Musics_MusicId",
                table: "MusicTrack",
                column: "MusicId",
                principalTable: "Musics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
