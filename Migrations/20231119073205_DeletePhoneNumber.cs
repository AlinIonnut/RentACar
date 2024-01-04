using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar.Migrations
{
    /// <inheritdoc />
    public partial class DeletePhoneNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Persons");

            migrationBuilder.CreateTable(
                name: "RentalCreateDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PickUpTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    DropOfTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    PickUpLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DropOfLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalCreateDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentalCreateDto_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentalCreateDto_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RentalCreateDto_CarId",
                table: "RentalCreateDto",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalCreateDto_PersonId",
                table: "RentalCreateDto",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentalCreateDto");

            migrationBuilder.AddColumn<int>(
                name: "PhoneNumber",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
