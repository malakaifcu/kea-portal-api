using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoanPortalAPIDev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class UserAuthController : ControllerBase
    {
        private readonly ILogger<UserAuthController> logger;

        public UserAuthController(ILogger<UserAuthController> logger)
        {
            this.logger = logger;
        }



        // GET: api/<UserAuthController>
        [HttpGet]
        [SwaggerOperation("Get user")]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        public async Task<ActionResult> Get(string id)
        {
            return Ok("Works");
        }

        // GET api/<UserAuthController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserAuthController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserAuthController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserAuthController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
