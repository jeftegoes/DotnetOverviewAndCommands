using System.Text.Json;

static WeatherForecast ExampleSerializeObject()
{
    return new WeatherForecast
    {
        Date = DateTime.Parse("2019-08-01"),
        TemperatureCelsius = 25,
        Summary = "Hot",
        SummaryField = "Hot",
        DatesAvailable = new List<DateTimeOffset>() { DateTime.Parse("2019-08-01"), DateTime.Parse("2019-08-02") },
        SummaryWords = new[] { "Cool", "Windy", "Humid" }
    };
}

static T DeserializeJson<T>(string json)
{
    if (string.IsNullOrWhiteSpace(json))
    {
        return default(T);
    }

    try
    {
        var serializer = JsonSerializer.Deserialize<T>(json);
        return (T)serializer;
    }
    catch
    {
        return default(T);
    }
}

static string SerializeJson<T>(T value)
{
    if (value == null)
    {
        return string.Empty;
    }

    try
    {
        return JsonSerializer.Serialize<T>(value);
    }
    catch
    {
        return string.Empty;
    }
}

static string ExampleDeserializeJsonString()
{
    var jsonString = @" [
                            {
                                ""Id"": 1,
                                ""Name"": ""Client 1"",
                                ""ProductId"": 1,
                                ""ProductName"": ""Shoes"",
                                ""Quantity"": 1,
                                ""Price"": 123.22,
                                ""Discount"": 0
                            },
                            {
                                ""Id"": 2,
                                ""Name"": ""Client 2"",
                                ""ProductId"": 2,
                                ""ProductName"": ""Shirt"",
                                ""Quantity"": 2,
                                ""Price"": 45.5,
                                ""Discount"": 5.5
                            },
                            {
                                ""Id"": 3,
                                ""Name"": ""Client 3"",
                                ""ProductId"": 3,
                                ""ProductName"": ""Basket ball"",
                                ""Quantity"": 1,
                                ""Price"": 99,
                                ""Discount"": 0
                            }
                        ]";

    return jsonString;
}

Console.WriteLine(SerializeJson<WeatherForecast>(ExampleSerializeObject()));
Console.WriteLine("");
var orders = DeserializeJson<List<Order>>(ExampleDeserializeJsonString());
orders.ForEach(x =>
{
    Console.WriteLine(x.Id);
    Console.WriteLine(x.Name);
    Console.WriteLine(x.Price);
    Console.WriteLine(x.ProductId);
    Console.WriteLine(x.ProductName);
});