using Microsoft.AspNetCore.Mvc;
using YugiApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YugiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MagicCardController : ControllerBase
    {
        // GET: api/<MagicCardController>
        [HttpGet]
        public IEnumerable<MagicCard> Get()
        {
            return new MagicCard[] mcs;
        }

        // GET api/<MagicCardController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MagicCardController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MagicCardController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MagicCardController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
