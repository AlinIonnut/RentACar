﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar.Migrations
{
    /// <inheritdoc />
    public partial class RegistrationNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumber",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                table: "Cars");
        }
    }
}
