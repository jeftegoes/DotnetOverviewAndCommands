public class WeatherForecast
{
    public DateTimeOffset Date { get; set; }
    public int TemperatureCelsius { get; set; }
    public string? Summary { get; set; }
    public string? SummaryField;
    public IList<DateTimeOffset>? DatesAvailable { get; set; }
    public string[]? SummaryWords { get; set; }
}