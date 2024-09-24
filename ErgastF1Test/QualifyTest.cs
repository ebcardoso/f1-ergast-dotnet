using ErgastF1.Services;

namespace ErgastF1Test
{
    public class QualifyingTest
    {
        [Fact]
        public async Task ListByRaceTest()
        {
            QualifyingServices qualifyingServices = new QualifyingServices();
            var response = await qualifyingServices.ListByRace(2024, 1);

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
                Assert.NotNull(response.Content.Races);
                foreach(var race in response.Content.Races)
                {
                    Assert.NotNull(race);
                    Assert.NotNull(race.Season);
                    Assert.NotNull(race.Round);
                    Assert.NotNull(race.Url);
                    Assert.NotNull(race.RaceName);
                    Assert.NotNull(race.Circuit);
                        Assert.NotNull(race.Circuit.CircuitId);
                        Assert.NotNull(race.Circuit.Url);
                        Assert.NotNull(race.Circuit.CircuitName);
                        Assert.NotNull(race.Circuit.Location);
                            Assert.NotNull(race.Circuit.Location.Lat);
                            Assert.NotNull(race.Circuit.Location.Long);
                            Assert.NotNull(race.Circuit.Location.Locality);
                            Assert.NotNull(race.Circuit.Location.Country);
                    Assert.NotNull(race.Date);
                    Assert.NotNull(race.Time);
                    Assert.NotNull(race.QualifyingResults);
                    foreach(var qualifyingsResult in race.QualifyingResults)
                    {
                        Assert.NotNull(qualifyingsResult);
                        Assert.NotNull(qualifyingsResult.Number);
                        Assert.NotNull(qualifyingsResult.Position);
                        Assert.NotNull(qualifyingsResult.Driver);
                            Assert.NotNull(qualifyingsResult.Driver.DriverId);
                            Assert.NotNull(qualifyingsResult.Driver.Url);
                            Assert.NotNull(qualifyingsResult.Driver.GivenName);
                            Assert.NotNull(qualifyingsResult.Driver.FamilyName);
                            Assert.NotNull(qualifyingsResult.Driver.DateOfBirth);
                            Assert.NotNull(qualifyingsResult.Driver.Nationality);
                        Assert.NotNull(qualifyingsResult.Constructor);
                            Assert.NotNull(qualifyingsResult.Constructor.ConstructorId);
                            Assert.NotNull(qualifyingsResult.Constructor.Url);
                            Assert.NotNull(qualifyingsResult.Constructor.Name);
                            Assert.NotNull(qualifyingsResult.Constructor.Nationality);
                    }
                }
        }
    }
}
