using Newtonsoft.Json;

using (HttpClient client = new HttpClient())
{
    var url = "https://restcountries.com/v3.1/all";
    var response = await client.GetAsync(url);
    var json = await response.Content.ReadAsStringAsync();

    var countries = JsonConvert.DeserializeObject<List<Country>>(json);

    foreach (var country in countries)
    {
        Console.WriteLine(country.Name.Common);
    }
}