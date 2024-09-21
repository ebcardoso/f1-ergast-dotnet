using ErgastF1.Services;

namespace ErgastF1Test
{
    public class FinishingStatusTest
    {
        [Fact]
        public async Task ListTest()
        {
            FinishingStatusServices fsServices = new FinishingStatusServices();
            var response = await fsServices.List();

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.StatusTable);
                Assert.NotNull(response.StatusTable.Status);
                foreach(var status in response.StatusTable.Status)
                {
                    Assert.NotNull(status);
                    Assert.NotNull(status.StatusId);
                    Assert.NotNull(status.Count);
                    Assert.NotNull(status.Status);
                }
        }

        [Fact]
        public async Task ListBySeasonTest()
        {
            FinishingStatusServices fsServices = new FinishingStatusServices();
            var response = await fsServices.ListBySeason(2024);

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.StatusTable);
                Assert.NotNull(response.StatusTable.Season);
                Assert.NotNull(response.StatusTable.Status);
                foreach(var status in response.StatusTable.Status)
                {
                    Assert.NotNull(status);
                    Assert.NotNull(status.StatusId);
                    Assert.NotNull(status.Count);
                    Assert.NotNull(status.Status);
                }
        }

        [Fact]
        public async Task ListByRaceTest()
        {
            FinishingStatusServices fsServices = new FinishingStatusServices();
            var response = await fsServices.ListByRace(2024, 1);

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.StatusTable);
                Assert.NotNull(response.StatusTable.Season);
                Assert.NotNull(response.StatusTable.Round);
                Assert.NotNull(response.StatusTable.Status);
                foreach(var status in response.StatusTable.Status)
                {
                    Assert.NotNull(status);
                    Assert.NotNull(status.StatusId);
                    Assert.NotNull(status.Count);
                    Assert.NotNull(status.Status);
                }
        }
    }
}
