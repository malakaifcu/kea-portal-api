using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;
using LoanPortalAPIDev.Models;
using System.Diagnostics;
namespace LoanPortalAPIDev.Utilities
{
    public class OCC_Auth
    { 

        public string Token() {
            HttpClient httpClient = new HttpClient();
            var authHeaders = httpClient.DefaultRequestHeaders;
            authHeaders.Add("Accept", "application/json");
            string auth_url = "https://online.firstcreditunion.co.nz/SOVFCUT-OCC/occ-api/v1.0/login_phase_1/token";
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, auth_url);
            request.Content = new FormUrlEncodedContent(new Dictionary<string, string> {
                { "client_id", "RESTUSER"},
                { "client_secret", "jZIhsCFyHRoXYrdH"},
                { "grant_type", "client_credentials"},
                { "username", ""},
                { "password", ""},
                { "uuid", ""},
                { "device_type", ""},
                { "pin", ""},
                { "bio_secret", ""},
                { "mobile_app_id", ""},
                { "mobile_app_version", ""}
            });
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
            
            using(httpClient)
            {
                HttpResponseMessage response = new HttpResponseMessage();
                response = httpClient.PostAsync(auth_url, request.Content).Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    var res = JsonConvert.DeserializeObject<OCC_Auth_Model>(json);
                    if(res != null) return res.access_token.ToString();
                }
            }

            return "";
        }

        
    }
}
