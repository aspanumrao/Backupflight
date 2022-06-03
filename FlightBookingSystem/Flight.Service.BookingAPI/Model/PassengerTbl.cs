using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Flight.Service.BookingAPI.Model
{
    public class PassengerTbl
    {    [Key]
        public int  MemberId { get; set; }
        public string PassengerFirstName { get; set; }
        public string PassengerMiddle { get; set; }
        public string PassengerLastName { get; set; }
        public int SeatNumber { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }     
       // public virtual int  BookedRef { get; set; }
        [ForeignKey("BookId")]
        public virtual BookingTbl BookingTbls { get; set; }
    }
    
}
