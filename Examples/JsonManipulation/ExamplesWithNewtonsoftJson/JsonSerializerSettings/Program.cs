using Newtonsoft.Json;

var family = new Dictionary<int, string>
{
    {1, "jefté"},
    {2, "bárbara"},
    {3, "brenno"},
    {4, "dora"},
    {5, "sabrina"}
};

var settings = new JsonSerializerSettings
{
    Formatting = Formatting.Indented
};

var json = JsonConvert.SerializeObject(family, settings);

Console.WriteLine(json);