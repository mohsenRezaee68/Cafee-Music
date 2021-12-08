using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountMangement.Infrastructure.EFCore.Migrations
{
    public partial class hhhhhhh001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsRemoved",
                table: "Accounts",
                newName: "IsConfirmed");

            migrationBuilder.AddColumn<bool>(
                name: "IsCanceled",
                table: "Accounts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCanceled",
                table: "Accounts");

            migrationBuilder.RenameColumn(
                name: "IsConfirmed",
                table: "Accounts",
                newName: "IsRemoved");
        }
    }
}
