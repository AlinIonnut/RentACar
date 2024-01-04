using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar.Migrations
{
    /// <inheritdoc />
    public partial class AddPhoneNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Prefix",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Prefix",
                table: "Persons");
        }
    }
}
