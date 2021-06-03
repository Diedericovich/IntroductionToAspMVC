using IntroductionToAspMVC.Models;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Services
{
    public interface IWeatherService
    {
        Task<Weather> GetWeatherModel(string city);
    }
}