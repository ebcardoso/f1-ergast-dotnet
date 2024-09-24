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
            Assert.NotNull(response.Content);
                Assert.NotNull(response.Content.Seasons);
                    foreach (var season in response.Content.Seasons)
                    {
                        Assert.NotNull(season.SeasonYear);
                        Assert.NotNull(season.Url);
                    }
        }
    }
}