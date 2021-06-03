using IntroductionToAspMVC.Data.Weather;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Data
{
    public interface IWeatherRepo
    {
        Task<WeatherEntity> GetWeatherEntityAsync(string city);
    }
}