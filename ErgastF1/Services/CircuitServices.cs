using ErgastF1.DTO;

namespace ErgastF1.Services
{
    public class CircuitServices : Service
    {
        public CircuitServices() { }

        // ergast.com/api/f1/circuits.json
        public async Task<CircuitDTO> List(int offset = 0, int limit = 10)
        {
            string path = "circuits";
            string query = $"?offset={offset}&limit={limit}";
            var response = await SendRequest<CircuitResponse>(path, query);

            return response.Data;
        }

        // ergast.com/api/f1/{year}/circuits.json
        public async Task<CircuitDTO> ListBySeason(int year, int offset = 0, int limit = 10)
        {
            string path = $"{year}/circuits";
            string query = $"?offset={offset}&limit={limit}";
            var response = await SendRequest<CircuitResponse>(path, query);

            return response.Data;
        }

        // ergast.com/api/f1/{year}/{round}/circuits.json
        public async Task<CircuitDTO> ListByRace(int year, int round, int offset = 0, int limit = 10)
        {
            string path = $"{year}/{round}/circuits";
            string query = $"?offset={offset}&limit={limit}";
            var response = await SendRequest<CircuitResponse>(path, query);

            return response.Data;
        }

        // ergast.com/api/f1/{circuitId}/circuits.json
        public async Task<CircuitDTO> FindByID(string id)
        {
            string path = $"circuits/{id}";
            var response = await SendRequest<CircuitResponse>(path);

            return response.Data;
        }
    }
}
