using Flight.Service.FlightSearchAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight.Service.FlightSearchAPI.DBContext
{
    public class FlightSearchDbContext : DbContext
    {
        public FlightSearchDbContext(DbContextOptions<FlightSearchDbContext> options):base (options)
        {

        }
        public DbSet<FlightSearchTbl> flightSearchTbls { get; set; }
    }
}
