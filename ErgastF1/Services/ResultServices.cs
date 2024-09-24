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
            return await SendRequest<RaceDTO>(path, "");
        }

        // ergast.com/api/f1/{year}/{round}/results.json
        public async Task<RaceDTO> ListByRace(int year, int round)
        {
            string path = $"{year}/{round}/results";
            return await SendRequest<RaceDTO>(path, "");
        }
    }
}
