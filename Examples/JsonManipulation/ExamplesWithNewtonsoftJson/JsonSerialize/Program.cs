using Newtonsoft.Json;

var weatherForecast = new WeatherForecast
{
    Date = DateTime.Parse("2019-08-01"),
    TemperatureCelsius = 25,
    Summary = "Hot",
    SummaryField = "Hot",
    DatesAvailable = new List<DateTimeOffset>() { DateTime.Parse("2019-08-01"), DateTime.Parse("2019-08-02") },
    SummaryWords = new[] { "Cool", "Windy", "Humid" }
};

var json = JsonConvert.SerializeObject(weatherForecast);
Console.Write(json);