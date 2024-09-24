using ErgastF1.Connection;
using ErgastF1.DTO;
using Newtonsoft.Json;

namespace ErgastF1.Services
{
    public class Service
    {
        protected readonly RequestAPI request;

        public Service()
        {
            request = new RequestAPI();
        }

        protected async Task<T> SendRequest<T>(string path, string query = "")
        {
            HttpResponseMessage response = await request.Get(path, query);
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonObject = JsonConvert.DeserializeObject<ErgastResponse<T>>(jsonString);
                return jsonObject.Data;
            }
            else
            {
                throw new Exception("Error to connect to API.");
            }
        }
    }
}
