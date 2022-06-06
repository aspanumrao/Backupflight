using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flight.Service.FlightSearchAPI.Model
{
    public class FlightSearchTbl
    {
        [Key]
        public int FlightId { get; set; }
        public  string FlightNo { get; set; }
        public  string FlightLogo { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public  DateTime DepartureDate { get; set; }
        public  DateTime ReturnDate { get; set; }
        public bool OneWay { get; set; }
        public bool RoundWay { get; set; }
        public bool IsFlightBlock { get; set; }
        public double Price { get; set; }
        public int AvailableSheet { get; set; }
    }
}
