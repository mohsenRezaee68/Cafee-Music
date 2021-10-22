using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicManagement.Infrastructure.EFCore.Migrations
{
    public partial class TrackMusic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MusicTrack",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusicId = table.Column<long>(type: "bigint", nullable: false),
                    Track = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicTrack", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusicTrack_Musics_MusicId",
                        column: x => x.MusicId,
                        principalTable: "Musics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MusicTrack_MusicId",
                table: "MusicTrack",
                column: "MusicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MusicTrack");
        }
    }
}
