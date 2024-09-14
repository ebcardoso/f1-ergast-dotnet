using ErgastF1.DTO;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System;

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

            var response = await SendRequest<LapResponse>(path, query);

            return response.Data;
        }
    }
}
