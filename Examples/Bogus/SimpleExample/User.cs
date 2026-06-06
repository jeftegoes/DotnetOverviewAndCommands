public class User
{
    public string Name { get; set; } = string.Empty;
    public string Occupation { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"{Name} {Occupation}";
    }
}