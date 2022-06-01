using Flight.Service.FlightSearchAPI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flight.Service.FlightSearchAPI.Repository
{
    public interface ISearchRepository
    {
       
        IEnumerable<FlightSearchTbl>  FlightSearch(FlightSearchTbl flightSearchAPI );


    }
}
