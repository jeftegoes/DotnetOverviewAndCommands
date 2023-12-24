using System.Net.Http.Json;

var url = "https://api.zippopotam.us/us/90210";

using (HttpClient client = new HttpClient())
{
    var postalAddress = await client.GetFromJsonAsync<PostalAddress>(url);

    if (postalAddress != null)
    {
        foreach (var place in postalAddress.Places)
        {
            Console.WriteLine(place.State);
        }
    }
}