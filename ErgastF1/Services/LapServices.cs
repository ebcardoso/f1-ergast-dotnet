using ErgastF1.DTO;

namespace ErgastF1.Services
{
    public class LapServices : Service
    {
        public LapServices() { }

        // ergast.com/api/f1/{year}/{round}/laps/{lap}.json
        public async Task<LapDTO> ListLapTimes(int year, int round, int lap, int offset=0, int limit=10)
        {
            string path = $"{year}/{round}/laps/{lap}";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<LapDTO>(path, query);
        }
    }
}
