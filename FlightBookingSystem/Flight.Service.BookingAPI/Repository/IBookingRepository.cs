﻿using Flight.Service.BookingAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight.Service.BookingAPI.Repository
{
    public interface IBookingRepository
    {
       IEnumerable<BookingTbl> BookingTicket( BookingTbl bookingtbl);
    }
}
