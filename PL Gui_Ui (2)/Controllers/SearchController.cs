using BLL;
using Enteties_Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PL_Gui_Ui__2_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        // GET: api/<SearchController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SearchController>/5
        [HttpGet()]
        [Route("Search Word")]
        public List<LocationDto> GetWords(string searchTxt)
        {
            SmartSearch search = new SmartSearch();
            List<LocationDto> results = search.searchWord(searchTxt);
            return results;

        }

        // GET api/<SearchController>/5
        [HttpGet()]
        [Route("Search pasuk to name")]
        public List<LocationDto2> GetPasukToName(string name)
        {
            SearchInJsonFile search = new SearchInJsonFile();
            List<LocationDto2> results = search.searchPasukToName(name);
            return results;
        }


        // POST api/<SearchController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SearchController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SearchController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
