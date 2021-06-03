using AutoMapper;
using GenericLibrary;
using IntroductionToAspMVC.Data;
using IntroductionToAspMVC.Data.Weather;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Services
{
    public class WeatherService : IWeatherService
    {
        private IWeatherRepo _repo;
        private IMapper _mapper;

        public WeatherService(IWeatherRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Models.Weather> GetWeatherModel(string city)
        {
            WeatherEntity entity = await _repo.GetWeatherEntityAsync(city);
            Models.Weather model = _mapper.Map<Models.Weather>(entity);

            model.Temperature = TemperatureConverter.KelvinToCelsius(model.Temperature);
            model.MinTemperature = TemperatureConverter.KelvinToCelsius(model.MinTemperature);
            model.MaxTemperature = TemperatureConverter.KelvinToCelsius(model.MaxTemperature);


            return model;
        }
    }
}
