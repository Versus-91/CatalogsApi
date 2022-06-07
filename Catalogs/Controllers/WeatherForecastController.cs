using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Catalogs.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// نمایش دمای هوا
        /// </summary>
        /// <param name="id">شناسه ایتم</param>
        /// <returns></returns>
        /// <remarks>
        /// ### نکته ###
        /// Use this call to retrieve a list of entities and their descriptions. This is used when setting up a new ViewSet.
        /// - Returns an array of **EntityDescription** objects.
        /// - اریهیسی شس شسیسشی 
        /// <!-- 
        /// <code>
        ///     // contrived code sample to demonstrate code block in swagger.
        ///     for (i=0; i < 5; i++)
        ///     {
        ///         doesthiswork = yesitdoes;
        ///     }
        /// </code>
        /// -->
        /// </remarks>

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get([Required]int id)
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("GetWeatherForecas1t")]
        public IEnumerable<WeatherForecast> Get1([Required] int id)
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet("GetWeatherForecast2")]
        public IEnumerable<WeatherForecast> Get2([Required] int id)
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost("GetWeatherForecast3")]
        public IEnumerable<WeatherForecast> Get3( WeatherForecast weather)
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpDelete("GetWeatherForecast4")]
        public IEnumerable<WeatherForecast> Get4([Required] int id)
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}