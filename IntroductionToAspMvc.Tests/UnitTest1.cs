using AutoMapper;
using IntroductionToAspMVC.Data;
using IntroductionToAspMVC.Helpers;
using IntroductionToAspMVC.Services;
using NUnit.Framework;
using System.Threading.Tasks;

namespace IntroductionToAspMvc.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task PlaceholderTestAsync()
        {
            // ARRANGE
            string city = "Gent";
            WeatherRepo repo = new WeatherRepo();

            // ACT
            await repo.GetWeatherEntityAsync(city);

            // ASSERT
            var foo = "bar";
        }
    }
}