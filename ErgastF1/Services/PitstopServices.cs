using ErgastF1.DTO;

namespace ErgastF1.Services
{
    public class PitstopServices : Service
    {
        public PitstopServices() { }

        // ergast.com/api/f1/{year}/{round}/pitstops.json
        public async Task<PitstopDTO> ListByRace(int year, int round, int offset = 0, int limit = 10)
        {
            string path = $"{year}/{round}/pitstops";
            string query = $"?offset={offset}&limit={limit}";
            var response = await SendRequest<PitstopResponse>(path, query);

            return response.Data;
        }

        // ergast.com/api/f1/{year}/{round}/pitstops.json
        public async Task<PitstopDTO> ListByNumber(int year, int round, int number, int offset = 0, int limit = 10)
        {
            string path = $"{year}/{round}/pitstops/{number}";
            string query = $"?offset={offset}&limit={limit}";
            var response = await SendRequest<PitstopResponse>(path, query);

            return response.Data;
        }
    }
}
