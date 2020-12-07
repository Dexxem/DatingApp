using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class UserPasswordAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                "PasswordHash",
                "Users",
                "BLOB",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                "PasswordSalt",
                "Users",
                "BLOB",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "PasswordHash",
                "Users");

            migrationBuilder.DropColumn(
                "PasswordSalt",
                "Users");
        }
    }
}