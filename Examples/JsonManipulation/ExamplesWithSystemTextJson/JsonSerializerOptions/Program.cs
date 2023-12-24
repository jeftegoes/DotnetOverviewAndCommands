using System.Text.Json;

var family = new Dictionary<int, string>
{
    {1, "jefté"},
    {2, "bárbara"},
    {3, "brenno"},
    {4, "dora"},
    {5, "sabrina"}
};

var json = JsonSerializer.Serialize(family, new JsonSerializerOptions { WriteIndented = true });

Console.WriteLine(json);

Console.WriteLine("---------------------");

var dic = JsonSerializer.Deserialize<Dictionary<int, string>>(json);

foreach (var (key, value) in dic!)
{
    Console.WriteLine($"{key}: {value}");
}