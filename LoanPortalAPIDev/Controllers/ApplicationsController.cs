using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using LoanPortalAPIDev.Models;
using LoanPortalAPIDev.Utilities;
using System.Text.Json.Serialization;
using static LoanPortalAPIDev.Controllers.ApplicationsController;
using System.ComponentModel;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoanPortalAPIDev.Controllers
{
    [Route("/applications/v1.0")]
    [ApiController]
    
    [Produces("application/json")]
    public class ApplicationsController : ControllerBase
    {

        private readonly ILogger<ApplicationsController> _logger;

        public ApplicationsController(ILogger<ApplicationsController> logger)
        {
            _logger = logger;
        }

        public static Applications application = new Applications();
        public static SubmitApp_API submit = new SubmitApp_API();

        private HttpClient client = new HttpClient();

        [System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
        public enum ResponseTypes
        {
            min = 0,
            medium = 1,
            max = 2
        }

        /// <summary>
        /// Get application details.
        /// </summary>
        /// <remarks>
        /// Summary:
        /// This API enables the consumer to retrieve loan application data by providing the Application External Number.
        /// This API also supports three modes (min, medium and max) that each return data with different levels of details.
        /// 
        /// Function Detail:
        /// min: returns the status code, description and who it is allocated to. This is also the default response type.
        /// medium: returns all the attributes and linked objects defined in the Application model except for 
        /// Associated clients, securities as well as financial details.
        /// max: returns everything defined in the Application model.
        /// </remarks>
        /// <param name="appID">Application External Number</param>
        /// <param name="responseType">Response types</param>
        /// <returns>Application details</returns>
        // GET: api/<ApplicationsController>/5
        [HttpGet(Name ="GetApplication")]
        //[SwaggerOperation("GetApp")]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> Get([FromQuery]string appID, [FromQuery] ResponseTypes responseType)
        {
            OCC_Auth auth = new OCC_Auth();
            string token = auth.Token();

            string resSelected = responseType.ToString();

            using (client = new HttpClient())
            {
                string useID = $"{appID.PadRight(10 - appID.Length, '0')}";
                string getAppUrl = $"https://online.firstcreditunion.co.nz/SOVFCUT-OCC/occ-api/v1.0/private/applications/{useID}?response={resSelected}";
                var headers = client.DefaultRequestHeaders;
                headers.Add("x-occapi-request-by-client","0000572472");
                headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage response = client.GetAsync(getAppUrl).Result;

                response.EnsureSuccessStatusCode();
                string json = response.Content.ReadAsStringAsync().Result;
                var res = JsonConvert.DeserializeObject<Applications>(json);
                if (response.IsSuccessStatusCode)
                    if (res != null)
                    {
                        return Ok(res);
                    }
                    else
                        return BadRequest(await response.Content.ReadAsStringAsync());
            }

            return BadRequest();

        }

        /// <summary>
        /// Get a list of changed loan applications based on the specified change date.
        /// </summary>
        /// <param name="changedDateSince">Date-time since when to search for changed applications using ISO 8601 date-time-format</param>
        /// <returns></returns>
        [HttpGet("changedSince",Name ="GetModifiedApps")]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> RetrieveChangedApps([FromQuery] string changedDateSince="2023-10-25")
        {
            OCC_Auth auth = new OCC_Auth();
            string token = auth.Token();


            using (client = new HttpClient())
            {

                string getAppUrl = $"https://online.firstcreditunion.co.nz/SOVFCUT-OCC/occ-api/v1.0/private/applications/?changedDateSince={changedDateSince}";
                var headers = client.DefaultRequestHeaders;
                headers.Add("x-occapi-request-by-client", "0000572472");
                headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage response = client.GetAsync(getAppUrl).Result;

                response.EnsureSuccessStatusCode();
                string json = response.Content.ReadAsStringAsync().Result;
                var res = JsonConvert.DeserializeObject<ApplicationsByDateSince>(json);
                if (response.IsSuccessStatusCode)
                    if (res != null)
                    {
                        return Ok(res);
                    }
                    else
                        return BadRequest(await response.Content.ReadAsStringAsync());
            }

            return BadRequest();
        }

        // GET api/<ApplicationsController>/5
        [HttpGet("api/[controller]/{id}")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public string Get(int id)
        {
            if (User.Identity.IsAuthenticated) {
                return "Authenticated";
            }
            return "Not authenticated";
        }

        // POST api/<ApplicationsController>
        /// <summary>
        /// Submit a new loan application.
        /// </summary>
        /// <param name="newApp"></param>
        /// <returns>A newly created application</returns>
        /// <remarks>
        /// Sample request below.
        /// </remarks>
        /// <response code="200">Returns the newly created application</response>
        [HttpPost(Name ="SubmitApplication")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ApiExplorerSettings(IgnoreApi = false)]
        public async Task<ActionResult> Post([FromBody] ApplicationSubmission newApp)
        {
            submit = new SubmitApp_API();
            await submit.SubmitApp(newApp);

            return Ok();
        }

        // PUT api/<ApplicationsController>/5
        [HttpPut("{id}")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public void Put(int id, [FromBody] ApplicationSubmission newApp)
        {

        }

        // DELETE api/<ApplicationsController>/5
        [HttpDelete("{id}")]
        [ApiExplorerSettings(IgnoreApi =true)]
        public void Delete(int id)
        {

        }
    }
}
