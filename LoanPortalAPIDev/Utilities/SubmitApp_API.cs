using LoanPortalAPIDev.Models;
using Newtonsoft.Json;
using System.Text;

namespace LoanPortalAPIDev.Utilities
{
    public class SubmitApp_API
    {
        

        public async Task<OCC_SubmitApp_Response> SubmitApp(ApplicationSubmission submission) {

            HttpClient httpClient = new HttpClient();
            var authHeaders = httpClient.DefaultRequestHeaders;
            authHeaders.Add("Accept", "application/json");
            string submit_url = "";
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, submit_url);
            var data = JsonConvert.SerializeObject(submission);
            var payload = new StringContent(data, Encoding.UTF8, "application/json");
            
            using (httpClient)
            {
                HttpResponseMessage response = new HttpResponseMessage();
                response = httpClient.PostAsync(submit_url, request.Content).Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    var res = JsonConvert.DeserializeObject<OCC_SubmitApp_Response>(json);
                    if (res != null) return res;
                }
            }

            return null;
        }

    }
}
