using Newtonsoft.Json;

var json = @" [
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

var orders = JsonConvert.DeserializeObject<List<Order>>(json);

foreach (var order in orders)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine(order);
    Console.WriteLine(order.Name);
    Console.WriteLine(order.Price);
    Console.WriteLine(order.ProductName);
}
Console.WriteLine("-----------------------");