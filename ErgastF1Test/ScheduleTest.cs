using ErgastF1.Services;

namespace ErgastF1Test
{
    public class ScheduleTest
    {
        [Fact]
        public async Task ListByCurrentSeasonTest()
        {
            ScheduleServices scheduleServices = new ScheduleServices();
            var response = await scheduleServices.ListByCurrentSeason();

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.Content);
                Assert.NotNull(response.Content.Season);
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
                    Assert.NotNull(race.FirstPractice);
                        Assert.NotNull(race.FirstPractice.Date);
                        Assert.NotNull(race.FirstPractice.Time);
                    Assert.NotNull(race.SecondPractice);
                        Assert.NotNull(race.SecondPractice.Date);
                        Assert.NotNull(race.SecondPractice.Time);
                    Assert.NotNull(race.Qualifying);
                        Assert.NotNull(race.Qualifying.Date);
                        Assert.NotNull(race.Qualifying.Time);
                }
        }
    
        [Fact]
        public async Task ListBySeasonTest()
        {
            ScheduleServices scheduleServices = new ScheduleServices();
            var response = await scheduleServices.ListBySeason(2024);

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.Content);
                Assert.NotNull(response.Content.Season);
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
                    Assert.NotNull(race.FirstPractice);
                        Assert.NotNull(race.FirstPractice.Date);
                        Assert.NotNull(race.FirstPractice.Time);
                    Assert.NotNull(race.SecondPractice);
                        Assert.NotNull(race.SecondPractice.Date);
                        Assert.NotNull(race.SecondPractice.Time);
                    Assert.NotNull(race.Qualifying);
                        Assert.NotNull(race.Qualifying.Date);
                        Assert.NotNull(race.Qualifying.Time);
                }
        }
    
        [Fact]
        public async Task ListByRaceTest()
        {
            ScheduleServices scheduleServices = new ScheduleServices();
            var response = await scheduleServices.ListByRace(2024, 1);

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
                    Assert.NotNull(race.FirstPractice);
                        Assert.NotNull(race.FirstPractice.Date);
                        Assert.NotNull(race.FirstPractice.Time);
                    Assert.NotNull(race.SecondPractice);
                        Assert.NotNull(race.SecondPractice.Date);
                        Assert.NotNull(race.SecondPractice.Time);
                    Assert.NotNull(race.Qualifying);
                        Assert.NotNull(race.Qualifying.Date);
                        Assert.NotNull(race.Qualifying.Time);
                }
        }
    
    }
}
