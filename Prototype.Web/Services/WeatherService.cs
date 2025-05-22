using Prototype.Web.Interfaces;

namespace Prototype.Web.Services
{
	public class WeatherService : ISingletonService, IScopedService, ITransientService
	{
		WeatherForecast[] weathers = Method();
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Rainy", "Chilly", "Windy", "Cloudy", "Sunny", "Hot", "Warm", "Cold", "Storm"
		};

		public WeatherForecast[] GetForecastAsync()
		{
					
			return weathers;
		}

		public static WeatherForecast[] Method()
		{
			DateOnly startDate = new DateOnly(2025, 05, 21);
			WeatherForecast[] weathers = Enumerable.Range(0, 3).Select(index => new WeatherForecast
			{
				Date = startDate.AddDays(index),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			}).ToArray();
			return weathers;
		}

	}

	public class WeatherForecast
	{
		public DateOnly Date { get; set; }
		public int TemperatureC { get; set; }
		public string? Summary { get; set; }
		public int TemperatureF => 32 + (int) (TemperatureC / 0.5556);

	}
}
