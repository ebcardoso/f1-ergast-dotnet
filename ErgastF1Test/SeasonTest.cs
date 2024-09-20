using ErgastF1.Services;

namespace ErgastF1Test
{
    public class SeasonTest
    {
        [Fact]
        public async Task List()
        {
            SeasonServices seasonServices = new SeasonServices();
            var response = await seasonServices.List();

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.SeasonTable);
                Assert.NotNull(response.SeasonTable.Seasons);
                    foreach (var season in response.SeasonTable.Seasons)
                    {
                        Assert.NotNull(season.SeasonYear);
                        Assert.NotNull(season.Url);
                    }
        }
    }
}