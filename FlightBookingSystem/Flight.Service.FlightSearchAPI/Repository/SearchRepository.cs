using Flight.Service.FlightSearchAPI.DBContext;
using Flight.Service.FlightSearchAPI.Model;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight.Service.FlightSearchAPI.Repository
{
    public class SearchRepository : ISearchRepository
    {

        private readonly FlightSearchDbContext flightcontext;
        public SearchRepository(FlightSearchDbContext flightcont)
        {
            flightcontext = flightcont;
        }
        //Flight Search Logic as per user criteria
        public IEnumerable<FlightSearchTbl> FlightSearch(FlightSearchTbl searchcritera)
        {
            List<FlightSearchTbl> objflightlist = new List<FlightSearchTbl>();
            //var availableflights = flightcontext.flightSearchTbls.Where(x => x.From == searchcritera.From && x.To == searchcritera.To)
            //    .Select(x => new { x.FlightNo, x.FlightLogo, x.Price }).ToList();

       
            var  availableflights = (from res in flightcontext.flightSearchTbls
                                    where (res.From == searchcritera.From && res.To == searchcritera.To && res.IsFlightBlock==false)
                                    select new { res.From, res.To, res.FlightLogo, res.Price, res.FlightNo,res.DepartureDate,res.ReturnDate,res.AvailableSheet }
                                       ) ;




            foreach (var item in availableflights)
            {
                FlightSearchTbl objflight = new FlightSearchTbl();
                objflight.From = item.From;
                objflight.To = item.To;
                objflight.FlightLogo = item.FlightLogo;               
                objflight.Price = item.Price;
                objflight.FlightNo = item.FlightNo;
                objflight.DepartureDate = item.DepartureDate;
                objflight.ReturnDate = item.ReturnDate;
                objflight.AvailableSheet = item.AvailableSheet;

                objflightlist.Add(objflight);
            }


            return objflightlist;
        }
        // end 

        
    }
}
