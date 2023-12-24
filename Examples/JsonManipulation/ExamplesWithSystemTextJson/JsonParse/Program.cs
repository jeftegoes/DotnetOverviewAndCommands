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
    Console.WriteLine(root);

    var u1 = root[0];
    var u2 = root[1];
    
    Console.WriteLine("First element: {0}", u1);
    Console.WriteLine("Second element: {0}", u2);

    Console.WriteLine(u1.GetProperty("name"));
    Console.WriteLine(u1.GetProperty("occupation"));

    Console.WriteLine(u2.GetProperty("name"));
    Console.WriteLine(u2.GetProperty("occupation"));
}