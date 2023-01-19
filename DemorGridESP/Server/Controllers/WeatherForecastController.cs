using DemorGridESP.Shared;
using Microsoft.AspNetCore.Mvc;

namespace DemorGridESP.Server.Controllers
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

        [HttpGet]
        public IEnumerable<WeatherForecast> Get(bool sortByAscending, string columna)
        {
            var temperaturas = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            });

            if (columna == "Date")
            {
                if (sortByAscending)
                {
                    temperaturas = temperaturas.OrderBy(x => x.Date);
                }
                else
                {
                    temperaturas = temperaturas.OrderByDescending(x => x.Date);
                }
            }

            return temperaturas;
        }
    }
}