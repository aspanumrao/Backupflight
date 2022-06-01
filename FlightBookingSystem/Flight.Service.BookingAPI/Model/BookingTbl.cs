using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Flight.Service.BookingAPI.Model
{
    public class BookingTbl
    {
        public int BookId { get; set; }
        public string FlightNo { get; set; }
        public string EmailId { get; set; }
        public string OptForMeal { get; set; }
        public int NoOfSeat { get; set; }
        public int SelectSeatNumber  { get; set; }
        public string BookingFrom { get; set; }
        public string BookingTo { get; set; }
        public  DateTime BookingDepartureDate { get; set; }
        public DateTime BookingReturnDate { get; set; }
        public  bool IsBookingOneWay { get; set; }
        public bool IsBookingRoundWay { get; set; }
        IList<Passenger>listpassengers { get; set; }


    }
    public class Passenger
    {
        [Key]
        public int PassengerId { get; set; }
        public string PassengerFirstName { get; set; }
        public string PassengerMiddle { get; set; }
        public string PassengerLastName { get; set; }
        public int Age { get; set; }
        [ForeignKey("BookingTbl")]
        public int BookId { get; set; }

    }
   
}
