using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight.Service.FlightSearchAPI.Model;
using Flight.Service.InventoryAPI.InvRepository;

namespace Flight.Service.InventoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryRepository _invRepository;

      
        public InventoryController(IInventoryRepository invRepository)
        {
            this._invRepository = invRepository;
        }
        [HttpGet]
        [Route("getallactiveflight")]
        public IEnumerable<FlightSearchTbl> GetAllActiveFlight()
        {
            return _invRepository.GetAllFlight();
        }
  
     
        [HttpPost]
        [Route("flightregistration")]
        public void AddedNewFlight([FromBody] FlightSearchTbl flightSearchTbl)
        {

            _invRepository.RegisterInventory(flightSearchTbl);
        }
        [HttpPost]
        [Route("flightblock/{id}")]
        public void BlockFlight(int id)
        {

            _invRepository.BlockAirline(id);
          
        }

        [HttpPost]
        [Route("flightschedule")]
        public FlightSearchTbl FlightScheduleUpdate(FlightSearchTbl objflightserchalter)
        {

            return _invRepository.ManageSchedule(objflightserchalter);

        }



    }
}
