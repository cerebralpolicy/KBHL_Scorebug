using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KBHL_Scorebug_APP
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreboardValues : ControllerBase
    {
        // GET: api/<ScoreboardValues>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ScoreboardValues>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ScoreboardValues>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ScoreboardValues>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ScoreboardValues>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
