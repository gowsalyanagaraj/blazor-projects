using Prototype.Web.Services;

namespace Prototype.Web.Interfaces
{
	public interface ITransientService
	{
		WeatherForecast[] GetForecastAsync();
	}
}
