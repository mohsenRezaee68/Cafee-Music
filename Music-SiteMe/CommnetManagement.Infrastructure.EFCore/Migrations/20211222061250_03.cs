using Microsoft.EntityFrameworkCore.Migrations;

namespace CommnetManagement.Infrastructure.EFCore.Migrations
{
    public partial class _03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OwnerRecordId",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "OwnerRecordCatgory",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerRecordName",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerRecordSinger",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerRecordCatgory",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "OwnerRecordName",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "OwnerRecordSinger",
                table: "Comments");

            migrationBuilder.AlterColumn<long>(
                name: "OwnerRecordId",
                table: "Comments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
