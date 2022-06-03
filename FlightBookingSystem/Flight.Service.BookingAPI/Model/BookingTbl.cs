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
        [Key]
        public int BookId { get; set; }
        [Required]
        public string FlightNo { get; set; }
        public string PNRNo { get; set; }
        public bool IsPNRNoActive { get; set; }
        [Required]
        public string EmailId { get; set; }
        public string OptForMeal { get; set; }
        [Required]
        public int NoOfSeat { get; set; }        
        [Required]
        public string BookingFrom { get; set; }
        [Required]
        public string BookingTo { get; set; }
        [Required]
        public  DateTime BookingDepartureDate { get; set; }
        [Required]
        public DateTime BookingReturnDate { get; set; }
        [Required]
        public  bool IsBookingOneWay { get; set; }
        [Required]
        public bool IsBookingRoundWay { get; set; }
       public List<PassengerTbl> listpassengers { get; set; }


    }
    
   
}
