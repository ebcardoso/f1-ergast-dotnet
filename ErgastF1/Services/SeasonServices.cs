using ErgastF1.DTO;

namespace ErgastF1.Services
{
    public class SeasonServices : Service
    {
        // ergast.com/api/f1/seasons.json
        public async Task<SeasonDTO> List(int offset = 0, int limit = 10)
        {
            string path = "seasons";
            string query = $"?offset={offset}&limit={limit}";
            var response = await SendRequest<SeasonResponse>(path, query);

            return response.Data;
        }
    }
}
