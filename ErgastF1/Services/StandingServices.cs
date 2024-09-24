using ErgastF1.DTO;

namespace ErgastF1.Services
{
    public class StandingServices : Service
    {
        public StandingServices() { }

        /* DRIVERS */

        // ergast.com/api/f1/current/driverStandings.json
        public async Task<StandingDTO> DriversCurrentStanding()
        {
            string path = "current/driverStandings";
            return await SendRequest<StandingDTO>(path);
        }

        // ergast.com/api/f1/{{year}}/driverStandings.json
        public async Task<StandingDTO> DriversBySeason(int year, int offset = 0, int limit = 10)
        {
            string path = $"{year}/driverStandings";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<StandingDTO>(path, query);
        }

        // ergast.com/api/f1/{{year}}/{{round}}/driverStandings.json
        public async Task<StandingDTO> DriversAfterRace(int year, int round, int offset = 0, int limit = 10)
        {
            string path = $"{year}/{round}/driverStandings";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<StandingDTO>(path, query);
        }

        // ergast.com/api/f1/{{year}}/{{round}}/driverStandings.json
        public async Task<StandingDTO> StandingHistoryByDriver(string driverId, int offset = 0, int limit = 10)
        {
            string path = $"drivers/{driverId}/driverStandings";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<StandingDTO>(path, query);
        }

        // ergast.com/api/f1/driverStandings/1.json
        public async Task<StandingDTO> ChampionsHistoryByDrivers(int offset = 0, int limit = 10)
        {
            string path = $"driverStandings/1";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<StandingDTO>(path, query);
        }

        /* CONSTRUCTORS */

        // ergast.com/api/f1/current/constructorStandings.json
        public async Task<StandingDTO> ConstructorsCurrentStanding()
        {
            string path = "current/constructorStandings";
            return await SendRequest<StandingDTO>(path);
        }


        // ergast.com/api/f1/{{year}}/constructorStandings.json
        public async Task<StandingDTO> ConstructorsBySeason(int year, int offset = 0, int limit = 10)
        {
            string path = $"{year}/constructorStandings";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<StandingDTO>(path, query);
        }

        // ergast.com/api/f1/{{year}}/{{round}}/constructorStandings.json
        public async Task<StandingDTO> ConstructorsAfterRace(int year, int round, int offset = 0, int limit = 10)
        {
            string path = $"{year}/{round}/constructorStandings";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<StandingDTO>(path, query);
        }

        // ergast.com/api/f1/{{year}}/{{round}}/constructorStandings.json
        public async Task<StandingDTO> StandingHistoryByConstructor(string constructorId, int offset = 0, int limit = 10)
        {
            string path = $"constructors/{constructorId}/constructorStandings";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<StandingDTO>(path, query);
        }

        // ergast.com/api/f1/constructorStandings/1.json
        public async Task<StandingDTO> ChampionsHistoryByConstructors(int offset = 0, int limit = 10)
        {
            string path = $"constructorStandings/1";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<StandingDTO>(path, query);
        }
    }
}
