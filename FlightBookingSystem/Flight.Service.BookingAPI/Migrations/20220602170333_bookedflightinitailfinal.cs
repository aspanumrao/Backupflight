using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight.Service.BookingAPI.Migrations
{
    public partial class bookedflightinitailfinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bookingTbls",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FlightNo = table.Column<string>(nullable: false),
                    PNRNo = table.Column<string>(nullable: true),
                    IsPNRNoActive = table.Column<bool>(nullable: false),
                    EmailId = table.Column<string>(nullable: false),
                    OptForMeal = table.Column<string>(nullable: true),
                    NoOfSeat = table.Column<int>(nullable: false),
                    BookingFrom = table.Column<string>(nullable: false),
                    BookingTo = table.Column<string>(nullable: false),
                    BookingDepartureDate = table.Column<DateTime>(nullable: false),
                    BookingReturnDate = table.Column<DateTime>(nullable: false),
                    IsBookingOneWay = table.Column<bool>(nullable: false),
                    IsBookingRoundWay = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookingTbls", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "passengerTbls",
                columns: table => new
                {
                    MemberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PassengerFirstName = table.Column<string>(nullable: true),
                    PassengerMiddle = table.Column<string>(nullable: true),
                    PassengerLastName = table.Column<string>(nullable: true),
                    SeatNumber = table.Column<int>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    BookId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passengerTbls", x => x.MemberId);
                    table.ForeignKey(
                        name: "FK_passengerTbls_bookingTbls_BookId",
                        column: x => x.BookId,
                        principalTable: "bookingTbls",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_passengerTbls_BookId",
                table: "passengerTbls",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "passengerTbls");

            migrationBuilder.DropTable(
                name: "bookingTbls");
        }
    }
}
