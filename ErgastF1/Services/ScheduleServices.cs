using ErgastF1.DTO;

namespace ErgastF1.Services
{
    public class ScheduleServices : Service
    {
        public ScheduleServices() { }

        // ergast.com/api/f1/current.json
        public async Task<RaceDTO> ListByCurrentSeason(int offset = 0, int limit = 10)
        {
            string path = "current";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<RaceDTO>(path, query);
        }

        // ergast.com/api/f1/{year}.json
        public async Task<RaceDTO> ListBySeason(int year, int offset = 0, int limit = 10)
        {
            string path = $"{year}";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<RaceDTO>(path, query);
        }

        // ergast.com/api/f1/{year}/{round}.json
        public async Task<RaceDTO> ListByRace(int year, int round)
        {
            string path = $"{year}/{round}";
            return await SendRequest<RaceDTO>(path, "");
        }
    }
}
