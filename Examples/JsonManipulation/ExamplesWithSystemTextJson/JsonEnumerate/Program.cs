using System.Text.Json;

var json = @"[
   {
      ""name"":""Jefté"",
      ""occupation"":""Software Engineer""
   },
   {
      ""name"":""Brenno"",
      ""occupation"":""Student""
   }
]";

using (JsonDocument doc = JsonDocument.Parse(json))
{
    var root = doc.RootElement;

    var users = root.EnumerateArray();

    while (users.MoveNext())
    {
        var user = users.Current;
        Console.WriteLine(user);

        var props = user.EnumerateObject();

        while (props.MoveNext())
        {
            var prop = props.Current;
            Console.WriteLine($"{prop.Name}: {prop.Value}");
        }
    }
}