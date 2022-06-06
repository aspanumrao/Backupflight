using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight.Service.FlightSearchAPI.Model;

namespace Flight.Service.InventoryAPI.InvRepository
{
  public  interface IInventoryRepository
    {
        void RegisterInventory(FlightSearchTbl flightSearchTbl);
        void BlockAirline(int id);
        FlightSearchTbl ManageSchedule(FlightSearchTbl alterflighttblobj);
    }
}
