﻿using ErgastF1.DTO;
using System.Collections.Generic;

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
            var response = await SendRequest<StandingResponse>(path);

            return response.Data;
        }

        // ergast.com/api/f1/{{year}}/driverStandings.json
        public async Task<StandingDTO> DriversBySeason(int year, int offset = 0, int limit = 10)
        {
            string path = $"{year}/driverStandings";
            string query = $"?offset={offset}&limit={limit}";
            var response = await SendRequest<StandingResponse>(path, query);

            return response.Data;
        }

        // ergast.com/api/f1/{{year}}/{{round}}/driverStandings.json
        public async Task<StandingDTO> DriversAfterRace(int year, int round, int offset = 0, int limit = 10)
        {
            string path = $"{year}/{round}/driverStandings";
            string query = $"?offset={offset}&limit={limit}";
            var response = await SendRequest<StandingResponse>(path, query);

            return response.Data;
        }

        // ergast.com/api/f1/{{year}}/{{round}}/driverStandings.json
        public async Task<StandingDTO> StandingHistoryByDriver(string driverId, int offset = 0, int limit = 10)
        {
            string path = $"drivers/{driverId}/driverStandings";
            string query = $"?offset={offset}&limit={limit}";
            var response = await SendRequest<StandingResponse>(path, query);

            return response.Data;
        }

        // ergast.com/api/f1/driverStandings/1.json
        public async Task<StandingDTO> ChampionsHistoryByDrivers(int offset = 0, int limit = 10)
        {
            string path = $"driverStandings/1";
            string query = $"?offset={offset}&limit={limit}";
            var response = await SendRequest<StandingResponse>(path, query);

            return response.Data;
        }
    }
}
