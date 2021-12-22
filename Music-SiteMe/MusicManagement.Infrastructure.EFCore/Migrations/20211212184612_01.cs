using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicManagement.Infrastructure.EFCore.Migrations
{
    public partial class _01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MusicCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    PictureAlt = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PictureTitle = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Keywords = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    MetaDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Musics",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Dawnlod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Singer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Melyat = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Sabk = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Ferestande = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    PictureAlt = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PictureTitle = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Keywords = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MetaDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Trak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musics_MusicCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "MusicCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TakMusic",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Singer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Melyat = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Sabk = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Ferestande = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    PictureAlt = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PictureTitle = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Keywords = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MetaDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Trak = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakMusic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TakMusic_MusicCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "MusicCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MusicTrack",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrackId = table.Column<long>(type: "bigint", nullable: false),
                    Track = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    TrackName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicTrack", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusicTrack_MusicCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "MusicCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MusicTrack_Musics_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Musics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Musics_CategoryId",
                table: "Musics",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MusicTrack_CategoryId",
                table: "MusicTrack",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MusicTrack_TrackId",
                table: "MusicTrack",
                column: "TrackId");

            migrationBuilder.CreateIndex(
                name: "IX_TakMusic_CategoryId",
                table: "TakMusic",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MusicTrack");

            migrationBuilder.DropTable(
                name: "TakMusic");

            migrationBuilder.DropTable(
                name: "Musics");

            migrationBuilder.DropTable(
                name: "MusicCategories");
        }
    }
}
