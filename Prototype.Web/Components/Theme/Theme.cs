namespace Prototype.Web;

public enum Themes
{
	LightTheme,
	DarkTheme
}

public class Theme
{
	public Themes Themes { get; set; }
	public string? HeaderClass { get; set; }
	public string? MainClass { get; set; }
	public string? CardClass { get; set; }
	public string? ButtonClass { get; set; }
	public string? FooterClass { get; set; }
}
