﻿using ErgastF1.Services;

namespace ErgastF1Test
{
    public class ConstructorTest
    {
        [Fact]
        public async Task ListTest()
        {
            ConstructorServices constructorServices = new ConstructorServices();
            var response = await constructorServices.List();

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.Content);
                Assert.NotNull(response.Content.Constructors);
                    foreach (var constructor in response.Content.Constructors)
                    {
                        Assert.NotNull(constructor.ConstructorId);
                        Assert.NotNull(constructor.Url);
                        Assert.NotNull(constructor.Name);
                        Assert.NotNull(constructor.Nationality);
                    }
        }

        [Fact]
        public async Task ListBySeasonTest()
        {
            ConstructorServices constructorServices = new ConstructorServices();
            var response = await constructorServices.ListBySeason(2024);

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.Content);
                Assert.NotNull(response.Content.Season);
                Assert.NotNull(response.Content.Constructors);
                    foreach (var constructor in response.Content.Constructors)
                    {
                        Assert.NotNull(constructor.ConstructorId);
                        Assert.NotNull(constructor.Url);
                        Assert.NotNull(constructor.Name);
                        Assert.NotNull(constructor.Nationality);
                    }
        }

        [Fact]
        public async Task ListByRaceTest()
        {
            ConstructorServices constructorServices = new ConstructorServices();
            var response = await constructorServices.ListByRace(2024, 1);

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
                Assert.NotNull(response.Content.Constructors);
                    foreach (var constructor in response.Content.Constructors)
                    {
                        Assert.NotNull(constructor.ConstructorId);
                        Assert.NotNull(constructor.Url);
                        Assert.NotNull(constructor.Name);
                        Assert.NotNull(constructor.Nationality);
                    }
        }

        [Fact]
        public async Task FindByID()
        {
            ConstructorServices constructorServices = new ConstructorServices();
            var response = await constructorServices.FindByID("benetton");

            Assert.NotNull(response);
            Assert.NotNull(response.Xmlns);
            Assert.NotNull(response.Series);
            Assert.NotNull(response.Url);
            Assert.NotNull(response.Limit);
            Assert.NotNull(response.Offset);
            Assert.NotNull(response.Total);
            Assert.NotNull(response.Content);
                Assert.NotNull(response.Content.ConstructorId);
                Assert.Equal("benetton", response.Content.ConstructorId);
                Assert.NotNull(response.Content.Constructors);
                    foreach (var constructor in response.Content.Constructors)
                    {
                        Assert.NotNull(constructor.ConstructorId);
                        Assert.Equal("benetton", constructor.ConstructorId);
                        Assert.NotNull(constructor.Url);
                        Assert.Equal("http://en.wikipedia.org/wiki/Benetton_Formula", constructor.Url);
                        Assert.NotNull(constructor.Name);
                        Assert.Equal("Benetton", constructor.Name);
                        Assert.NotNull(constructor.Nationality);
                        Assert.Equal("Italian", constructor.Nationality);
            }
        }
    }
}
