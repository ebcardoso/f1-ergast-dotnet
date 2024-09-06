using ErgastF1.DTO;

namespace ErgastF1.Services
{
    public class DriversServices : Service
    {
        public DriversServices() { }

        // ergast.com/api/f1/drivers.json
        public async Task<DriverDTO> List(int offset = 0, int limit = 10)
        {
            string path = "drivers";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<DriverDTO>(path, query);
        }

        // ergast.com/api/f1/{year}/drivers.json
        public async Task<DriverDTO> ListBySeason(int year, int offset = 0, int limit = 10)
        {
            string path = $"{year}/drivers";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<DriverDTO>(path, query);
        }

        // ergast.com/api/f1/{year}/{round}/drivers.json
        public async Task<DriverDTO> ListByRace(int year, int round, int offset = 0, int limit = 10)
        {
            string path = $"{year}/{round}/drivers";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<DriverDTO>(path, query);
        }

        // ergast.com/api/f1/{driverId}/drivers.json
        public async Task<DriverDTO> FindByID(string id)
        {
            string path = $"drivers/{id}";
            return await SendRequest<DriverDTO>(path);
        }
    }
}
