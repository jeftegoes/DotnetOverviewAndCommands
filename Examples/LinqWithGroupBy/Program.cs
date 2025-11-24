using System.Text.Json;
using ExampleWithGroupBy;

static List<Order> BreakUpEntity()
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

    var orders = JsonSerializer.Deserialize<List<Orders>>(jsonString);

    var order = orders
        .GroupBy(tm => new
        {
            tm.Id,
            tm.Name
        },
        (key, g) => new Order
        {
            Id = key.Id,
            Name = key.Name,
            OrderDetail = g.Select(x => new OrderDetail
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                Quantity = x.Quantity,
                Price = x.Price,
                Discount = x.Discount,
            }).ToList()
        })
        .ToList();

    return order;
}

BreakUpEntity().ForEach(x =>
{
    Console.WriteLine("Master: ");
    Console.WriteLine(x.Id);
    Console.WriteLine(x.Name);

    Console.WriteLine("Detail: ");
    x.OrderDetail.ForEach(y =>
    {
        Console.WriteLine(y.ProductId);
        Console.WriteLine(y.ProductName);
    });
    
    Console.WriteLine("");
});