using Flight.Service.BookingAPI.DBContext;
using Flight.Service.BookingAPI.Model;
using RabbitMQ.Client;
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
            //QueuePro(bookingObj);
        }

       

        public static string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void  TicketCancellation(string pnrnumber)
        {

            if (pnrnumber != null)
            {
                
              BookingTbl objbooking = bookingDbContext.bookingTbls.Where(a=>a.PNRNo== pnrnumber).FirstOrDefault();
                if (objbooking != null)
                {
                    if (objbooking.PNRNo != null && objbooking.IsPNRNoActive == true)
                    {
                        objbooking.IsPNRNoActive = false;
                        bookingDbContext.SaveChanges();
                       // return "Ticket has been Cancelled :" + pnrnumber;
                    }
                }
                //return "Please Provide the correct  pnrno";
            }
           // return "Please Provide the pnrno";
        }

        public IEnumerable<BookingTbl> BookingHistory(string email)
        {
            List<BookingTbl> objlistbooking = new List<BookingTbl>();
            
           if (email != null)
            {
              
                var availableflights = (from res in bookingDbContext.bookingTbls
                                        where (res.EmailId == email &&res.IsPNRNoActive==true)
                                        select new { res.FlightNo, res.PNRNo, res.BookingDepartureDate, res.BookingFrom,res.NoOfSeat,res.OptForMeal }
                                    );
                foreach (var item in availableflights)
                {
                    BookingTbl objtbl = new BookingTbl();
                    objtbl.FlightNo = item.FlightNo;
                    objtbl.PNRNo = item.PNRNo;
                    objtbl.BookingDepartureDate = item.BookingDepartureDate;
                    objtbl.BookingFrom = item.BookingFrom;
                    objtbl.NoOfSeat = item.NoOfSeat;
                    objtbl.OptForMeal = item.OptForMeal;
                    objlistbooking.Add(objtbl);
                }
            }
            return objlistbooking;
        }

        static void QueuePro(BookingTbl bookingdata)
        {
            
            var factory = new ConnectionFactory
            {
                Uri = new Uri("amqp://guest:guest@localhost:5672")
            };
            var conn = factory.CreateConnection();
            var chan = conn.CreateModel();
            QueueProducer.Publish(chan, bookingdata);
        }
    }
}
