using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountMangement.Infrastructure.EFCore.Migrations
{
    public partial class ghjkiu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserMusic_Accounts_AccountId",
                table: "UserMusic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserMusic",
                table: "UserMusic");

            migrationBuilder.DropColumn(
                name: "Keywords",
                table: "UserMusic");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "UserMusic");

            migrationBuilder.DropColumn(
                name: "Trak",
                table: "UserMusic");

            migrationBuilder.RenameTable(
                name: "UserMusic",
                newName: "MusicTrackUser");

            migrationBuilder.RenameColumn(
                name: "Singer",
                table: "MusicTrackUser",
                newName: "TrackSinger");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "MusicTrackUser",
                newName: "TrackName");

            migrationBuilder.RenameColumn(
                name: "IsRemoved",
                table: "MusicTrackUser",
                newName: "IsConfirmed");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "MusicTrackUser",
                newName: "TrackId");

            migrationBuilder.RenameIndex(
                name: "IX_UserMusic_AccountId",
                table: "MusicTrackUser",
                newName: "IX_MusicTrackUser_TrackId");

            migrationBuilder.AddColumn<bool>(
                name: "IsCanceled",
                table: "MusicTrackUser",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Track",
                table: "MusicTrackUser",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "roleId",
                table: "MusicTrackUser",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MusicTrackUser",
                table: "MusicTrackUser",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_MusicTrackUser_roleId",
                table: "MusicTrackUser",
                column: "roleId");

            migrationBuilder.AddForeignKey(
                name: "FK_MusicTrackUser_Accounts_TrackId",
                table: "MusicTrackUser",
                column: "TrackId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MusicTrackUser_Roles_roleId",
                table: "MusicTrackUser",
                column: "roleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MusicTrackUser_Accounts_TrackId",
                table: "MusicTrackUser");

            migrationBuilder.DropForeignKey(
                name: "FK_MusicTrackUser_Roles_roleId",
                table: "MusicTrackUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MusicTrackUser",
                table: "MusicTrackUser");

            migrationBuilder.DropIndex(
                name: "IX_MusicTrackUser_roleId",
                table: "MusicTrackUser");

            migrationBuilder.DropColumn(
                name: "IsCanceled",
                table: "MusicTrackUser");

            migrationBuilder.DropColumn(
                name: "Track",
                table: "MusicTrackUser");

            migrationBuilder.DropColumn(
                name: "roleId",
                table: "MusicTrackUser");

            migrationBuilder.RenameTable(
                name: "MusicTrackUser",
                newName: "UserMusic");

            migrationBuilder.RenameColumn(
                name: "TrackSinger",
                table: "UserMusic",
                newName: "Singer");

            migrationBuilder.RenameColumn(
                name: "TrackName",
                table: "UserMusic",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "TrackId",
                table: "UserMusic",
                newName: "AccountId");

            migrationBuilder.RenameColumn(
                name: "IsConfirmed",
                table: "UserMusic",
                newName: "IsRemoved");

            migrationBuilder.RenameIndex(
                name: "IX_MusicTrackUser_TrackId",
                table: "UserMusic",
                newName: "IX_UserMusic_AccountId");

            migrationBuilder.AddColumn<string>(
                name: "Keywords",
                table: "UserMusic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "UserMusic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Trak",
                table: "UserMusic",
                type: "nvarchar(max)",
                maxLength: 10000,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserMusic",
                table: "UserMusic",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserMusic_Accounts_AccountId",
                table: "UserMusic",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
