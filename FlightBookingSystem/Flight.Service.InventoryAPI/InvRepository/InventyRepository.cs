using Flight.Service.FlightSearchAPI.DBContext;
using Flight.Service.FlightSearchAPI.Model;
using Flight.Service.InventoryAPI.InvRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight.Service.InventoryAPI.InvRepository
{
    public class InventyRepository : IInventoryRepository
    {
        private readonly FlightSearchDbContext flightSearchDbContext;
        public InventyRepository(FlightSearchDbContext flightSearchDbContext)
        {
            this.flightSearchDbContext = flightSearchDbContext;
        }
        //addding  the new airline logic
        public void RegisterInventory(FlightSearchTbl flightSearchTbl)
        {

            flightSearchDbContext.flightSearchTbls.Add(flightSearchTbl);
            flightSearchDbContext.SaveChanges();

        }
        //end 
        //Block the Airline 
        public void BlockAirline(int id )
        {
            FlightSearchTbl objflight=  flightSearchDbContext.flightSearchTbls.Find(id);
                 if (objflight != null)
            {
                objflight.IsFlightBlock = true;
                flightSearchDbContext.SaveChanges();
            }
        }
        //end 
    }
}
