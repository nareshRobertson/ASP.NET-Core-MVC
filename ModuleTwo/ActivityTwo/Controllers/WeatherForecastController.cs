using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ActivityTwo.Controllers {

	[ApiController]
	[Route("api/[controller]")]
	public class WeatherForecastController : ControllerBase {
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		private readonly ILogger<WeatherForecastController> _logger;

		public WeatherForecastController(ILogger<WeatherForecastController> logger) {
			_logger = logger;
		}

		[HttpGet]
		public IActionResult Get(int? id) {
			var rng = new Random();
			var weatherForecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast {
				Date = DateTime.Now.AddDays(index),
				TemperatureC = rng.Next(-20, 55),
				Summary = Summaries[rng.Next(Summaries.Length)]
			})
			.ToArray();

			if (id != null && id < weatherForecasts.Length) {
				return Ok(new WeatherForecast[] { weatherForecasts[id.Value] });
			}
			else if (id == null) {
				return Ok(weatherForecasts);
			}
			else {
				return NotFound();
			}
		}
	}
}
