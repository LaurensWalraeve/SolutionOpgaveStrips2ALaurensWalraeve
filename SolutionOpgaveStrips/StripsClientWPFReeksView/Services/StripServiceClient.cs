using Newtonsoft.Json;
using StripsClientWPFReeksView.Exceptions;
using StripsClientWPFReeksView.Model;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace StripsClientWPFReeksView.Services
{
    public class StripServiceClient
    {
        private HttpClient client;

        public StripServiceClient()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5044/api/Strips/"); // Adjust the base URL as needed
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<ReeksDTO> GetReeksDetailsAsync(int reeksId)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{reeksId}");
                response.EnsureSuccessStatusCode();

                string content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ReeksDTO>(content);
            }
            catch (HttpRequestException ex)
            {
                throw new StripServiceClientException("Error retrieving reeks details", ex);
            }
        }
    }
}
