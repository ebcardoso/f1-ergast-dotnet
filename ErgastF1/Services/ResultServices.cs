using ErgastF1.DTO;

namespace ErgastF1.Services
{
    public class ResultServices : Service
    {
        public ResultServices() { }

        // ergast.com/api/f1/current/last/results.json
        public async Task<RaceDTO> MostRecent()
        {
            string path = "current/last/results";
            var response = await SendRequest<RaceResponse>(path, "");

            return response.Data;
        }

        // ergast.com/api/f1/{year}/{round}/results.json
        public async Task<RaceDTO> ListByRace(int year, int round)
        {
            string path = $"{year}/{round}/results";
            var response = await SendRequest<RaceResponse>(path, "");

            return response.Data;
        }
    }
}
