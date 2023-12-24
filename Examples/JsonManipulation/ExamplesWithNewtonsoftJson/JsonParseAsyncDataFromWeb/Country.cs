using Newtonsoft.Json;

public class Country
{
    [JsonPropertyAttribute("name")]
    public Name Name { get; set; }
}