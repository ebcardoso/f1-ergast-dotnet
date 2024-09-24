namespace ErgastF1.Connection
{
    public class RequestAPI
    {
        private readonly string baseUrl;

        public RequestAPI()
        {
            baseUrl = "http://ergast.com/api/f1/";
        }

        public async Task<HttpResponseMessage> Get(string path, string query)
        {
            string url = $"{baseUrl}{path}.json{query}";

            Console.WriteLine(url);

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);
            return response;
        }
    }
}
