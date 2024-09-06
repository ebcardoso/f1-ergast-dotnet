using ErgastF1.DTO;

namespace ErgastF1.Services
{
    public class CircuitsServices : Service
    {
        public CircuitsServices() { }

        // ergast.com/api/f1/circuits.json
        public async Task<CircuitDTO> List(int offset = 0, int limit = 10)
        {
            string path = "circuits";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<CircuitDTO>(path, query);
        }

        // ergast.com/api/f1/{year}/circuits.json
        public async Task<CircuitDTO> ListBySeason(int year, int offset = 0, int limit = 10)
        {
            string path = $"{year}/circuits";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<CircuitDTO>(path, query);
        }

        // ergast.com/api/f1/{year}/{round}/circuits.json
        public async Task<CircuitDTO> ListByRace(int year, int round, int offset = 0, int limit = 10)
        {
            string path = $"{year}/{round}/circuits";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<CircuitDTO>(path, query);
        }

        // ergast.com/api/f1/{circuitId}/circuits.json
        public async Task<CircuitDTO> FindByID(string id)
        {
            string path = $"circuits/{id}";
            return await SendRequest<CircuitDTO>(path);
        }
    }
}
