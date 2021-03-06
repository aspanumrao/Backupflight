// <auto-generated />
using System;
using Flight.Service.BookingAPI.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Flight.Service.BookingAPI.Migrations
{
    [DbContext(typeof(BookingDbContext))]
    partial class BookingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Flight.Service.BookingAPI.Model.BookingTbl", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BookingDepartureDate");

                    b.Property<string>("BookingFrom")
                        .IsRequired();

                    b.Property<DateTime>("BookingReturnDate");

                    b.Property<string>("BookingTo")
                        .IsRequired();

                    b.Property<string>("EmailId")
                        .IsRequired();

                    b.Property<string>("FlightNo")
                        .IsRequired();

                    b.Property<bool>("IsBookingOneWay");

                    b.Property<bool>("IsBookingRoundWay");

                    b.Property<bool>("IsPNRNoActive");

                    b.Property<int>("NoOfSeat");

                    b.Property<string>("OptForMeal");

                    b.Property<string>("PNRNo");

                    b.HasKey("BookId");

                    b.ToTable("bookingTbls");
                });

            modelBuilder.Entity("Flight.Service.BookingAPI.Model.PassengerTbl", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<int?>("BookId");

                    b.Property<string>("Gender");

                    b.Property<string>("PassengerFirstName");

                    b.Property<string>("PassengerLastName");

                    b.Property<string>("PassengerMiddle");

                    b.Property<int>("SeatNumber");

                    b.HasKey("MemberId");

                    b.HasIndex("BookId");

                    b.ToTable("passengerTbls");
                });

            modelBuilder.Entity("Flight.Service.BookingAPI.Model.PassengerTbl", b =>
                {
                    b.HasOne("Flight.Service.BookingAPI.Model.BookingTbl", "BookingTbls")
                        .WithMany("listpassengers")
                        .HasForeignKey("BookId");
                });
#pragma warning restore 612, 618
        }
    }
}
