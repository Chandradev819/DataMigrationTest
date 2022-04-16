using DataMigrationTest.DAL;
using DataMigrationTest.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace DataMigrationTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IConfiguration configuration;
        public DataController(IHostingEnvironment hostingEnvironment, IConfiguration config)
        {
            _hostingEnvironment = hostingEnvironment;
            configuration = config;
        }

        // GET: api/<DataController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DataController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DataController>
        [HttpPost("SaveData")]
        public async Task<ActionResult<string>> Post([FromBody] string value)
        {
            string result = string.Empty;
            try
            {
                DataDAL dataDAL = new DataDAL();
                string contentRootPath = _hostingEnvironment.ContentRootPath;
                string JSON = System.IO.File.ReadAllText(contentRootPath + "/Data/InputData.json");
                result = await dataDAL.SaveDataAsync(JSON, configuration);
            }
            catch (Exception)
            {
                result = "exception happen in api";
                throw;
            }
            return Content(result);
        }

        // PUT api/<DataController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DataController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
