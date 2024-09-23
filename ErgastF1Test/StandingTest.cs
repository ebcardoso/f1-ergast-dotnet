using ErgastF1.Services;

namespace ErgastF1Test
{
    public class StandingTest
    {
        [Fact]
        public async Task DriversCurrentStandingTest()
        {
            StandingServices standingServices = new StandingServices();
            var response = await standingServices.DriversCurrentStanding();

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.StandingsTable);
                Assert.NotNull(response.StandingsTable.Season);
                Assert.NotNull(response.StandingsTable.StandingsLists);
                foreach(var standingsLists in response.StandingsTable.StandingsLists)
                {
                    Assert.NotNull(standingsLists);
                    Assert.NotNull(standingsLists.Season);
                    Assert.NotNull(standingsLists.Round);
                    Assert.NotNull(standingsLists.DriverStandings);
                    foreach(var driverStandings in standingsLists.DriverStandings)
                    {
                        Assert.NotNull(driverStandings);
                        Assert.NotNull(driverStandings.Position);
                        Assert.NotNull(driverStandings.PositionText);
                        Assert.NotNull(driverStandings.Points);
                        Assert.NotNull(driverStandings.Wins);
                        Assert.NotNull(driverStandings.Driver);
                            Assert.NotNull(driverStandings.Driver.DriverId);
                            Assert.NotNull(driverStandings.Driver.Url);
                            Assert.NotNull(driverStandings.Driver.GivenName);
                            Assert.NotNull(driverStandings.Driver.FamilyName);
                            Assert.NotNull(driverStandings.Driver.DateOfBirth);
                            Assert.NotNull(driverStandings.Driver.Nationality);
                            foreach(var constructor in driverStandings.Constructors)
                            {
                                Assert.NotNull(constructor);
                                Assert.NotNull(constructor.ConstructorId);
                                Assert.NotNull(constructor.Url);
                                Assert.NotNull(constructor.Name);
                                Assert.NotNull(constructor.Nationality);
                            }
                    }                    
                }
        }
    
        [Fact]
        public async Task DriversBySeasonTest()
        {
            StandingServices standingServices = new StandingServices();
            var response = await standingServices.DriversBySeason(2023);

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.StandingsTable);
                Assert.NotNull(response.StandingsTable.Season);
                Assert.NotNull(response.StandingsTable.StandingsLists);
                foreach(var standingsLists in response.StandingsTable.StandingsLists)
                {
                    Assert.NotNull(standingsLists);
                    Assert.NotNull(standingsLists.Season);
                    Assert.NotNull(standingsLists.Round);
                    Assert.NotNull(standingsLists.DriverStandings);
                    foreach(var driverStandings in standingsLists.DriverStandings)
                    {
                        Assert.NotNull(driverStandings);
                        Assert.NotNull(driverStandings.Position);
                        Assert.NotNull(driverStandings.PositionText);
                        Assert.NotNull(driverStandings.Points);
                        Assert.NotNull(driverStandings.Wins);
                        Assert.NotNull(driverStandings.Driver);
                            Assert.NotNull(driverStandings.Driver.DriverId);
                            Assert.NotNull(driverStandings.Driver.Url);
                            Assert.NotNull(driverStandings.Driver.GivenName);
                            Assert.NotNull(driverStandings.Driver.FamilyName);
                            Assert.NotNull(driverStandings.Driver.DateOfBirth);
                            Assert.NotNull(driverStandings.Driver.Nationality);
                            foreach(var constructor in driverStandings.Constructors)
                            {
                                Assert.NotNull(constructor);
                                Assert.NotNull(constructor.ConstructorId);
                                Assert.NotNull(constructor.Url);
                                Assert.NotNull(constructor.Name);
                                Assert.NotNull(constructor.Nationality);
                            }
                    }                    
                }
        }
    
        [Fact]
        public async Task DriversAfterRaceTest()
        {
            StandingServices standingServices = new StandingServices();
            var response = await standingServices.DriversAfterRace(2023, 2);

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.StandingsTable);
                Assert.NotNull(response.StandingsTable.Season);
                Assert.NotNull(response.StandingsTable.Round);
                Assert.NotNull(response.StandingsTable.StandingsLists);
                foreach(var standingsLists in response.StandingsTable.StandingsLists)
                {
                    Assert.NotNull(standingsLists);
                    Assert.NotNull(standingsLists.Season);
                    Assert.NotNull(standingsLists.Round);
                    Assert.NotNull(standingsLists.DriverStandings);
                    foreach(var driverStandings in standingsLists.DriverStandings)
                    {
                        Assert.NotNull(driverStandings);
                        Assert.NotNull(driverStandings.Position);
                        Assert.NotNull(driverStandings.PositionText);
                        Assert.NotNull(driverStandings.Points);
                        Assert.NotNull(driverStandings.Wins);
                        Assert.NotNull(driverStandings.Driver);
                            Assert.NotNull(driverStandings.Driver.DriverId);
                            Assert.NotNull(driverStandings.Driver.Url);
                            Assert.NotNull(driverStandings.Driver.GivenName);
                            Assert.NotNull(driverStandings.Driver.FamilyName);
                            Assert.NotNull(driverStandings.Driver.DateOfBirth);
                            Assert.NotNull(driverStandings.Driver.Nationality);
                            foreach(var constructor in driverStandings.Constructors)
                            {
                                Assert.NotNull(constructor);
                                Assert.NotNull(constructor.ConstructorId);
                                Assert.NotNull(constructor.Url);
                                Assert.NotNull(constructor.Name);
                                Assert.NotNull(constructor.Nationality);
                            }
                    }                    
                }
        }
    
        [Fact]
        public async Task StandingHistoryByDriverTest()
        {
            StandingServices standingServices = new StandingServices();
            var response = await standingServices.StandingHistoryByDriver("barrichelo");

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.StandingsTable);
                Assert.NotNull(response.StandingsTable.DriverId);
                Assert.NotNull(response.StandingsTable.StandingsLists);
                foreach(var standingsLists in response.StandingsTable.StandingsLists)
                {
                    Assert.NotNull(standingsLists);
                    Assert.NotNull(standingsLists.Season);
                    Assert.NotNull(standingsLists.Round);
                    Assert.NotNull(standingsLists.DriverStandings);
                    foreach(var driverStandings in standingsLists.DriverStandings)
                    {
                        Assert.NotNull(driverStandings);
                        Assert.NotNull(driverStandings.Position);
                        Assert.NotNull(driverStandings.PositionText);
                        Assert.NotNull(driverStandings.Points);
                        Assert.NotNull(driverStandings.Wins);
                        Assert.NotNull(driverStandings.Driver);
                            Assert.NotNull(driverStandings.Driver.DriverId);
                            Assert.NotNull(driverStandings.Driver.Url);
                            Assert.NotNull(driverStandings.Driver.GivenName);
                            Assert.NotNull(driverStandings.Driver.FamilyName);
                            Assert.NotNull(driverStandings.Driver.DateOfBirth);
                            Assert.NotNull(driverStandings.Driver.Nationality);
                            foreach(var constructor in driverStandings.Constructors)
                            {
                                Assert.NotNull(constructor);
                                Assert.NotNull(constructor.ConstructorId);
                                Assert.NotNull(constructor.Url);
                                Assert.NotNull(constructor.Name);
                                Assert.NotNull(constructor.Nationality);
                            }
                    }                    
                }
        }
    
        [Fact]
        public async Task ChampionsHistoryByDriversTest()
        {
            StandingServices standingServices = new StandingServices();
            var response = await standingServices.ChampionsHistoryByDrivers();

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.StandingsTable);
                Assert.NotNull(response.StandingsTable.StandingsLists);
                foreach(var standingsLists in response.StandingsTable.StandingsLists)
                {
                    Assert.NotNull(standingsLists);
                    Assert.NotNull(standingsLists.Season);
                    Assert.NotNull(standingsLists.Round);
                    Assert.NotNull(standingsLists.DriverStandings);
                    foreach(var driverStandings in standingsLists.DriverStandings)
                    {
                        Assert.NotNull(driverStandings);
                        Assert.NotNull(driverStandings.Position);
                        Assert.NotNull(driverStandings.PositionText);
                        Assert.NotNull(driverStandings.Points);
                        Assert.NotNull(driverStandings.Wins);
                        Assert.NotNull(driverStandings.Driver);
                            Assert.NotNull(driverStandings.Driver.DriverId);
                            Assert.NotNull(driverStandings.Driver.Url);
                            Assert.NotNull(driverStandings.Driver.GivenName);
                            Assert.NotNull(driverStandings.Driver.FamilyName);
                            Assert.NotNull(driverStandings.Driver.DateOfBirth);
                            Assert.NotNull(driverStandings.Driver.Nationality);
                            foreach(var constructor in driverStandings.Constructors)
                            {
                                Assert.NotNull(constructor);
                                Assert.NotNull(constructor.ConstructorId);
                                Assert.NotNull(constructor.Url);
                                Assert.NotNull(constructor.Name);
                                Assert.NotNull(constructor.Nationality);
                            }
                    }                    
                }
        }
    
    }
}
