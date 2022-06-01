using Flight.Service.FlightSearchAPI.Model;
using Flight.Service.FlightSearchAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight.Service.FlightSearchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightSearchController : ControllerBase
    {
       private readonly ISearchRepository _searchRepository;
        public FlightSearchController(ISearchRepository _searchRepos)
        {

            _searchRepository= _searchRepos;
        }
        // GET api/values
       [HttpPost]
        [Route("flightsearch")]
        public IEnumerable<FlightSearchTbl> FlightSearch([FromBody] FlightSearchTbl flightsearch)
        {
            return   _searchRepository.FlightSearch(flightsearch);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
