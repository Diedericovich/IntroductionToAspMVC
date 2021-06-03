using IntroductionToAspMVC.Data.Weather;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Data
{
    public class WeatherRepo : IWeatherRepo
    {
        private const string apiId = "bc3ab5e266400e234d1f8b352e188cce";
        private const string apiUrl = "http://api.openweathermap.org/data/2.5";
        private string url;

        public async Task<WeatherEntity> GetWeatherEntityAsync(string city)
        {
            url = GenerateUrl(city);
            HttpResponseMessage message = await GetHttpResponseMessageAsync(url);
            WeatherEntity result = await GetEntityFromJsonAsync(message);

            return result;
        }

        private async Task<HttpResponseMessage> GetHttpResponseMessageAsync(string url)
        {
            var client = new HttpClient();
            HttpResponseMessage message = await client.GetAsync(url);

            if (!message.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Request failed: {message.StatusCode}");
            }

            return message;

        }

        private async Task<WeatherEntity> GetEntityFromJsonAsync(HttpResponseMessage message)
        {
            string json = await message.Content.ReadAsStringAsync();

            try
            {
                WeatherEntity result = JsonConvert.DeserializeObject<WeatherEntity>(json);
                return result;
            }
            catch (Exception e)
            {
                throw new JsonSerializationException("Serialization failed", e);
            }
        }

        private string GenerateUrl(string city)
        {
            if (city == null)
            {
                throw new ArgumentNullException(nameof(city));
            }

            return $"{apiUrl}/weather?q={city}&appId={apiId}";
        }
    }
}
