using ErgastF1.Services;

namespace ErgastF1Test
{
    public class StandingTest
    {
        /* DRIVERS */

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
            Assert.NotNull(response.Content);
                Assert.NotNull(response.Content.Season);
                Assert.NotNull(response.Content.StandingsLists);
                foreach(var standingsLists in response.Content.StandingsLists)
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
            Assert.NotNull(response.Content);
                Assert.NotNull(response.Content.Season);
                Assert.NotNull(response.Content.StandingsLists);
                foreach(var standingsLists in response.Content.StandingsLists)
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
            Assert.NotNull(response.Content);
                Assert.NotNull(response.Content.Season);
                Assert.NotNull(response.Content.Round);
                Assert.NotNull(response.Content.StandingsLists);
                foreach(var standingsLists in response.Content.StandingsLists)
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
            var driverName = "barrichelo";
            var response = await standingServices.StandingHistoryByDriver(driverName);

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.Content);
                Assert.NotNull(response.Content.DriverId);
                Assert.Equal(driverName, response.Content.DriverId);
                Assert.NotNull(response.Content.StandingsLists);
                foreach(var standingsLists in response.Content.StandingsLists)
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
            Assert.NotNull(response.Content);
                Assert.NotNull(response.Content.StandingsLists);
                foreach(var standingsLists in response.Content.StandingsLists)
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

        /* CONSTRUCTORS */
    
        [Fact]
        public async Task ConstructorsCurrentStandingTest()
        {
            StandingServices standingServices = new StandingServices();
            var response = await standingServices.ConstructorsCurrentStanding();

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.Content);
                Assert.NotNull(response.Content.Season);
                Assert.NotNull(response.Content.StandingsLists);
                foreach(var standingsLists in response.Content.StandingsLists)
                {
                    Assert.NotNull(standingsLists);
                    Assert.NotNull(standingsLists.Season);
                    Assert.NotNull(standingsLists.Round);
                    foreach(var constructorStandings in standingsLists.ConstructorStandings)
                    {
                        Assert.NotNull(constructorStandings);
                        Assert.NotNull(constructorStandings.Position);
                        Assert.NotNull(constructorStandings.PositionText);
                        Assert.NotNull(constructorStandings.Points);
                        Assert.NotNull(constructorStandings.Wins);
                        Assert.NotNull(constructorStandings.Constructor);
                            Assert.NotNull(constructorStandings.Constructor.ConstructorId);
                            Assert.NotNull(constructorStandings.Constructor.Url);
                            Assert.NotNull(constructorStandings.Constructor.Name);
                            Assert.NotNull(constructorStandings.Constructor.Nationality);
                    }                 
                }
        }
    
        [Fact]
        public async Task ConstructorsBySeasonTest()
        {
            StandingServices standingServices = new StandingServices();
            var response = await standingServices.ConstructorsBySeason(2024);

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.Content);
                Assert.NotNull(response.Content.Season);
                Assert.NotNull(response.Content.StandingsLists);
                foreach(var standingsLists in response.Content.StandingsLists)
                {
                    Assert.NotNull(standingsLists);
                    Assert.NotNull(standingsLists.Season);
                    Assert.NotNull(standingsLists.Round);
                    foreach(var constructorStandings in standingsLists.ConstructorStandings)
                    {
                        Assert.NotNull(constructorStandings);
                        Assert.NotNull(constructorStandings.Position);
                        Assert.NotNull(constructorStandings.PositionText);
                        Assert.NotNull(constructorStandings.Points);
                        Assert.NotNull(constructorStandings.Wins);
                        Assert.NotNull(constructorStandings.Constructor);
                            Assert.NotNull(constructorStandings.Constructor.ConstructorId);
                            Assert.NotNull(constructorStandings.Constructor.Url);
                            Assert.NotNull(constructorStandings.Constructor.Name);
                            Assert.NotNull(constructorStandings.Constructor.Nationality);
                    }                 
                }
        }
    
        [Fact]
        public async Task ConstructorsAfterRaceTest()
        {
            StandingServices standingServices = new StandingServices();
            var response = await standingServices.ConstructorsAfterRace(2024, 5);

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.Content);
                Assert.NotNull(response.Content.Season);
                Assert.NotNull(response.Content.Round);
                Assert.NotNull(response.Content.StandingsLists);
                foreach(var standingsLists in response.Content.StandingsLists)
                {
                    Assert.NotNull(standingsLists);
                    Assert.NotNull(standingsLists.Season);
                    Assert.NotNull(standingsLists.Round);
                    foreach(var constructorStandings in standingsLists.ConstructorStandings)
                    {
                        Assert.NotNull(constructorStandings);
                        Assert.NotNull(constructorStandings.Position);
                        Assert.NotNull(constructorStandings.PositionText);
                        Assert.NotNull(constructorStandings.Points);
                        Assert.NotNull(constructorStandings.Wins);
                        Assert.NotNull(constructorStandings.Constructor);
                            Assert.NotNull(constructorStandings.Constructor.ConstructorId);
                            Assert.NotNull(constructorStandings.Constructor.Url);
                            Assert.NotNull(constructorStandings.Constructor.Name);
                            Assert.NotNull(constructorStandings.Constructor.Nationality);
                    }                 
                }
        }
    
        [Fact]
        public async Task StandingHistoryByConstructorTest()
        {
            StandingServices standingServices = new StandingServices();
            var constructorName = "benetton";
            var response = await standingServices.StandingHistoryByConstructor(constructorName);

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.Content);
                Assert.NotNull(response.Content.ConstructorId);
                Assert.Equal(constructorName, response.Content.ConstructorId);
                Assert.NotNull(response.Content.StandingsLists);
                foreach(var standingsLists in response.Content.StandingsLists)
                {
                    Assert.NotNull(standingsLists);
                    Assert.NotNull(standingsLists.Season);
                    Assert.NotNull(standingsLists.Round);
                    foreach(var constructorStandings in standingsLists.ConstructorStandings)
                    {
                        Assert.NotNull(constructorStandings);
                        Assert.NotNull(constructorStandings.Position);
                        Assert.NotNull(constructorStandings.PositionText);
                        Assert.NotNull(constructorStandings.Points);
                        Assert.NotNull(constructorStandings.Wins);
                        Assert.NotNull(constructorStandings.Constructor);
                            Assert.NotNull(constructorStandings.Constructor.ConstructorId);
                            Assert.NotNull(constructorStandings.Constructor.Url);
                            Assert.NotNull(constructorStandings.Constructor.Name);
                            Assert.NotNull(constructorStandings.Constructor.Nationality);
                    }                 
                }
        }
    
        [Fact]
        public async Task ChampionsHistoryByConstructorsTest()
        {
            StandingServices standingServices = new StandingServices();
            var response = await standingServices.ChampionsHistoryByConstructors();

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.Content);
                Assert.NotNull(response.Content.StandingsLists);
                foreach(var standingsLists in response.Content.StandingsLists)
                {
                    Assert.NotNull(standingsLists);
                    Assert.NotNull(standingsLists.Season);
                    Assert.NotNull(standingsLists.Round);
                    foreach(var constructorStandings in standingsLists.ConstructorStandings)
                    {
                        Assert.NotNull(constructorStandings);
                        Assert.NotNull(constructorStandings.Position);
                        Assert.NotNull(constructorStandings.PositionText);
                        Assert.NotNull(constructorStandings.Points);
                        Assert.NotNull(constructorStandings.Wins);
                        Assert.NotNull(constructorStandings.Constructor);
                            Assert.NotNull(constructorStandings.Constructor.ConstructorId);
                            Assert.NotNull(constructorStandings.Constructor.Url);
                            Assert.NotNull(constructorStandings.Constructor.Name);
                            Assert.NotNull(constructorStandings.Constructor.Nationality);
                    }                 
                }
        }
    
    }
}
