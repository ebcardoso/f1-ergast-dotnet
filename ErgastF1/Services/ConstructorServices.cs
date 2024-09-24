using ErgastF1.DTO;

namespace ErgastF1.Services
{
    public class ConstructorServices : Service
    {
        public ConstructorServices() { }

        // ergast.com/api/f1/constructors.json
        public async Task<ConstructorDTO> List(int offset = 0, int limit = 10)
        {
            string path = "constructors";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<ConstructorDTO>(path, query);
        }

        // ergast.com/api/f1/{year}/constructors.json
        public async Task<ConstructorDTO> ListBySeason(int year, int offset = 0, int limit = 10)
        {
            string path = $"{year}/constructors";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<ConstructorDTO>(path, query);
        }

        // ergast.com/api/f1/{constructorsId}/constructors.json
        public async Task<ConstructorDTO> ListByRace(int year, int round, int offset = 0, int limit = 10)
        {
            string path = $"{year}/{round}/constructors";
            string query = $"?offset={offset}&limit={limit}";
            return await SendRequest<ConstructorDTO>(path, query);
        }

        // ergast.com/api/f1/{constructorsId}/constructors.json
        public async Task<ConstructorDTO> FindByID(string id)
        {
            string path = $"constructors/{id}";
            return await SendRequest<ConstructorDTO>(path);
        }
    }
}
