using ErgastF1.Services;

namespace ErgastF1Test
{
    public class DriverTest
    {
        [Fact]
        public async Task ListTest()
        {
            DriverServices driverServices = new DriverServices();
            var response = await driverServices.List();

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.DriverTable);
                Assert.NotNull(response.DriverTable.Drivers);
                    foreach (var driver in response.DriverTable.Drivers)
                    {
                        Assert.NotNull(driver.DriverId);
                        Assert.NotNull(driver.Url);
                        Assert.NotNull(driver.GivenName);
                        Assert.NotNull(driver.FamilyName);
                        Assert.NotNull(driver.DateOfBirth);
                        Assert.NotNull(driver.Nationality);
                    }
        }

        [Fact]
        public async Task ListBySeasonTest()
        {
            DriverServices driverServices = new DriverServices();
            var response = await driverServices.ListBySeason(2024);

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.DriverTable);
                Assert.NotNull(response.DriverTable.Season);
                Assert.NotNull(response.DriverTable.Drivers);
                    foreach (var driver in response.DriverTable.Drivers)
                    {
                        Assert.NotNull(driver.DriverId);
                        Assert.NotNull(driver.Url);
                        Assert.NotNull(driver.GivenName);
                        Assert.NotNull(driver.FamilyName);
                        Assert.NotNull(driver.DateOfBirth);
                        Assert.NotNull(driver.Nationality);
                    }
        }

        [Fact]
        public async Task ListByRaceTest()
        {
            DriverServices driverServices = new DriverServices();
            var response = await driverServices.ListByRace(2024, 1);

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.DriverTable);
                Assert.NotNull(response.DriverTable.Season);
                Assert.NotNull(response.DriverTable.Round);
                Assert.NotNull(response.DriverTable.Drivers);
                    foreach (var driver in response.DriverTable.Drivers)
                    {
                        Assert.NotNull(driver.DriverId);
                        Assert.NotNull(driver.Url);
                        Assert.NotNull(driver.GivenName);
                        Assert.NotNull(driver.FamilyName);
                        Assert.NotNull(driver.DateOfBirth);
                        Assert.NotNull(driver.Nationality);
                    }
        }

        [Fact]
        public async Task FindByID()
        {
            DriverServices driverServices = new DriverServices();
            var response = await driverServices.FindByID("barrichello");

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.DriverTable);
                Assert.NotNull(response.DriverTable.DriverId);
                Assert.Equal("barrichello", response.DriverTable.DriverId);
                Assert.NotNull(response.DriverTable.Drivers);
                    foreach (var driver in response.DriverTable.Drivers)
                    {
                        Assert.NotNull(driver.DriverId);
                        Assert.Equal("barrichello", driver.DriverId);
                        Assert.NotNull(driver.Url);
                        Assert.Equal("http://en.wikipedia.org/wiki/Rubens_Barrichello", driver.Url);
                        Assert.NotNull(driver.GivenName);
                        Assert.Equal("Rubens", driver.GivenName);
                        Assert.NotNull(driver.FamilyName);
                        Assert.Equal("Barrichello", driver.FamilyName);
                        Assert.NotNull(driver.DateOfBirth);
                        Assert.Equal("1972-05-23", driver.DateOfBirth);
                        Assert.NotNull(driver.Nationality);
                        Assert.Equal("Brazilian", driver.Nationality);
                    }
        }
    }
}
