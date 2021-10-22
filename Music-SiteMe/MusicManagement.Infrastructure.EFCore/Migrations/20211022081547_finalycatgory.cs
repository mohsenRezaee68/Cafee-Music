using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicManagement.Infrastructure.EFCore.Migrations
{
    public partial class finalycatgory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "MusicTrack");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "MusicTrack",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
