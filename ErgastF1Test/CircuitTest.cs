using ErgastF1.Services;

namespace ErgastF1Test
{
    public class CircuitTest
    {
        [Fact]
        public async Task ListTest()
        {
            CircuitServices circuitServices = new CircuitServices();
            var response = await circuitServices.List();

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.Content);
                Assert.NotNull(response.Content.Circuits);
                    foreach (var circuit in response.Content.Circuits)
                    {
                        Assert.NotNull(circuit.CircuitId);
                        Assert.NotNull(circuit.Url);
                        Assert.NotNull(circuit.CircuitName);
                        Assert.NotNull(circuit.Location);
                            Assert.NotNull(circuit.Location.Lat);
                            Assert.NotNull(circuit.Location.Long);
                            Assert.NotNull(circuit.Location.Locality);
                            Assert.NotNull(circuit.Location.Country);
                    }
        }

        [Fact]
        public async Task ListBySeasonTest()
        {
            CircuitServices circuitServices = new CircuitServices();
            var response = await circuitServices.ListBySeason(2024);

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.Content);
                Assert.NotNull(response.Content.Season);
                Assert.NotNull(response.Content.Circuits);
                    foreach (var circuit in response.Content.Circuits)
                    {
                        Assert.NotNull(circuit.CircuitId);
                        Assert.NotNull(circuit.Url);
                        Assert.NotNull(circuit.CircuitName);
                        Assert.NotNull(circuit.Location);
                        Assert.NotNull(circuit.Location.Lat);
                        Assert.NotNull(circuit.Location.Long);
                        Assert.NotNull(circuit.Location.Locality);
                        Assert.NotNull(circuit.Location.Country);

                    }
        }

        [Fact]
        public async Task ListByRaceTest()
        {
            CircuitServices circuitServices = new CircuitServices();
            var response = await circuitServices.ListByRace(2024, 1);

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
                Assert.NotNull(response.Content.Circuits);
                    foreach (var circuit in response.Content.Circuits)
                    {
                        Assert.NotNull(circuit.CircuitId);
                        Assert.NotNull(circuit.Url);
                        Assert.NotNull(circuit.CircuitName);
                        Assert.NotNull(circuit.Location);
                        Assert.NotNull(circuit.Location.Lat);
                        Assert.NotNull(circuit.Location.Long);
                        Assert.NotNull(circuit.Location.Locality);
                        Assert.NotNull(circuit.Location.Country);

                    }
        }

        [Fact]
        public async Task FindByID()
        {
            CircuitServices circuitServices = new CircuitServices();
            var response = await circuitServices.FindByID("hungaroring");

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
                Assert.NotNull(response.Content);
                    Assert.Equal("hungaroring", response.Content.CircuitId); 
                    Assert.NotNull(response.Content.Circuits);
                        foreach (var circuit in response.Content.Circuits)
                        {
                            Assert.NotNull(circuit.CircuitId);
                            Assert.Equal("hungaroring", circuit.CircuitId);
                            Assert.NotNull(circuit.Url);
                            Assert.Equal("http://en.wikipedia.org/wiki/Hungaroring", circuit.Url);
                            Assert.NotNull(circuit.CircuitName);
                            Assert.Equal("Hungaroring", circuit.CircuitName);
                            Assert.NotNull(circuit.Location);
                                    Assert.NotNull(circuit.Location.Lat);
                                    Assert.Equal("47.5789", circuit.Location.Lat);
                                    Assert.NotNull(circuit.Location.Long);
                                    Assert.Equal("19.2486", circuit.Location.Long);
                                    Assert.NotNull(circuit.Location.Locality);
                                    Assert.Equal("Budapest", circuit.Location.Locality);
                                    Assert.NotNull(circuit.Location.Country);
                                    Assert.Equal("Hungary", circuit.Location.Country);
                        }
        }
    }
}
