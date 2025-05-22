using Prototype.Web.Services;

namespace Prototype.Web.Interfaces
{
	public interface ISingletonService
	{
		WeatherForecast[] GetForecastAsync();
	}
}
