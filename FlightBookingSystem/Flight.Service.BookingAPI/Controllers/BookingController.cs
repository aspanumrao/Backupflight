using Flight.Service.BookingAPI.Model;
using Flight.Service.BookingAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight.Service.BookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingRepository _ibookingrepository;
        public BookingController(IBookingRepository bookingRepository)
        {
            _ibookingrepository = bookingRepository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "BookingController", "BookingController" };
        }

    
         [HttpPost]
         [Route("book")]
        public void BookingFlight([FromBody] BookingTbl bookingTbl)
        {
            _ibookingrepository.TicketBooking(bookingTbl);
        }

        [HttpPost]
        [Route("cancelled/{pnrno}")]
        public void  TicketCancellation(string pnrno)
        {
             _ibookingrepository.TicketCancellation(pnrno);
        }

        [HttpPost]
        [Route("history/{email}")]
        public IEnumerable<BookingTbl> BookingHistory(string email)
        {
            return _ibookingrepository.BookingHistory(email);
        }


    }
}
