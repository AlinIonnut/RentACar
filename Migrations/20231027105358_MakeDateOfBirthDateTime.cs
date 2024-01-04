using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar.Migrations
{
    /// <inheritdoc />
    public partial class MakeDateOfBirthDateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Persons",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DateOfBirth",
                table: "Persons",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
