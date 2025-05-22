using Prototype.Web.Services;

namespace Prototype.Web.Interfaces
{
	public interface IScopedService
	{
		WeatherForecast[] GetForecastAsync();
	}
}
