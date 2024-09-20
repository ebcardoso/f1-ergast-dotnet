using ErgastF1.DTO;
using System.Text;

namespace ErgastF1.Services
{
    public class QualifyingServices : Service
    {
        public QualifyingServices() { }

        // ergast.com/api/f1/{year}/{round}/qualifying.json
        public async Task<QualifyingDTO> ListByRace(int year, int round, int offset = 0, int limit = 10)
        {
            string path = $"{year}/{round}/qualifying";
            string query = $"?offset={offset}&limit={limit}";
            var response = await SendRequest<QualifyingResponse>(path, query);

            return response.Data;
        }
    }
}
