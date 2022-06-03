using Flight.Service.BookingAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Flight.Service.BookingAPI.DBContext
{
    public class BookingDbContext :DbContext
    {
        public BookingDbContext(DbContextOptions<BookingDbContext> options):base(options)
        {

        }
        public DbSet<BookingTbl> bookingTbls { get; set; }
        public DbSet<PassengerTbl> passengerTbls { get; set; }
    }
}
