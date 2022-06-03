using Flight.Service.BookingAPI.DBContext;
using Flight.Service.BookingAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight.Service.BookingAPI.Repository
{
    public class BookingRepository : IBookingRepository

    {
        private readonly BookingDbContext bookingDbContext;
        private static Random random = new Random();
        public BookingRepository(BookingDbContext bookingdbcon)
        {
            bookingDbContext = bookingdbcon;
        }
        public void  TicketBooking(BookingTbl bookingObj)
        {
            bookingObj.PNRNo = RandomString();
            bookingObj.IsPNRNoActive = true;
            bookingDbContext.bookingTbls.Add(bookingObj);
            //bookingDbContext.bookingTbls.
            bookingDbContext.SaveChanges();
            int bookingid = bookingObj.BookId;
            
           // return bookingid;
        }

       

        public static string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string TicketCancellation(string pnrno)
        {

            if (pnrno != null)
            {
                
              BookingTbl objbooking = bookingDbContext.bookingTbls.Where(a=>a.PNRNo==pnrno).FirstOrDefault();
                    if (objbooking.PNRNo!=null&&objbooking.IsPNRNoActive==true)
                    {
                    objbooking.IsPNRNoActive = false;
                    bookingDbContext.SaveChanges();
                        return "Ticket has been Cancelled :" + pnrno;
                    }
                    
                return "Please Provide the correct  pnrno";
            }
            return "Please Provide the pnrno";
        }
    }
}
