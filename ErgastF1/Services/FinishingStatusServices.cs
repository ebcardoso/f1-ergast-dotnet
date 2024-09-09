using ErgastF1.DTO;

namespace ErgastF1.Services
{
    public class FinishingStatusServices : Service
    {
        public FinishingStatusServices() { }

        // ergast.com/api/f1/status.json
        public async Task<FinishingStatusDTO> List(int offset = 0, int limit = 10)
        {
            string path = "status";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<FinishingStatusDTO>(path, query);
        }

        // ergast.com/api/f1/{year}/{round}/status.json
        public async Task<FinishingStatusDTO> ListBySeason(int year, int offset = 0, int limit = 10)
        {
            string path = $"{year}/status";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<FinishingStatusDTO>(path, query);
        }

        // ergast.com/api/f1/{year}/{round}/status.json
        public async Task<FinishingStatusDTO> ListByRace(int year, int round, int offset = 0, int limit = 10)
        {
            string path = $"{year}/{round}/status";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<FinishingStatusDTO>(path, query);
        }
    }
}
