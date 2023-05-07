using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rent_A_Car.Migrations
{
    public partial class SecondMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    DateOfPickup = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfReturn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "AppUserId", "CarId", "DateOfPickup", "DateOfReturn", "TotalPrice" },
                values: new object[] { 1, 3, 2, new DateTime(2023, 6, 5, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 5, 13, 30, 0, 0, DateTimeKind.Unspecified), 200 });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "AppUserId", "CarId", "DateOfPickup", "DateOfReturn", "TotalPrice" },
                values: new object[] { 2, 5, 1, new DateTime(2023, 11, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 600 });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "AppUserId", "CarId", "DateOfPickup", "DateOfReturn", "TotalPrice" },
                values: new object[] { 3, 1, 4, new DateTime(2023, 7, 5, 11, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 11, 11, 15, 0, 0, DateTimeKind.Unspecified), 540 });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_AppUserId",
                table: "Reservations",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CarId",
                table: "Reservations",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");
        }
    }
}
