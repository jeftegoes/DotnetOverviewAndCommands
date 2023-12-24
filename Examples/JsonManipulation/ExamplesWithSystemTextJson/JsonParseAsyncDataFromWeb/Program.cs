using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    var url = "https://restcountries.com/v3.1/all";
    var stream = await client.GetStreamAsync(url);

    using (JsonDocument response = await JsonDocument.ParseAsync(stream))
    {
        var root = response.RootElement;

        var elements = root.EnumerateArray();

        while (elements.MoveNext())
        {
            var node = elements.Current;
            Console.WriteLine(node.GetProperty("name").GetProperty("common"));
        }
    }
}