using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
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

        [HttpGet(Name = "GetWeatherForecast")]
        //[Authorize("weatherforecast:read")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("abc")]
        public IActionResult GetAbc()
        {
            return Ok(new { Message = "hello" });
        }

        [HttpGet("abc-private")]
        [Authorize]
        public IActionResult GetAbcPrivate()
        {
            return Ok(new { Message = "hello" });
        }

        [HttpGet("abc-private-scoped")]
        [Authorize("weatherforecast:read")]
        public IActionResult GetAbcPrivateScoped()
        {
            return Ok(new { Message = "hello scoped" });
        }

    }
}