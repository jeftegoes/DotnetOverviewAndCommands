using Bogus;

var occupations = new string[] { "gardener", "teacher", "writer", "programmer" };

var userFaker = new Faker<User>()
    .RuleFor(u => u.Name, f => f.Name.FullName())
    .RuleFor(u => u.Occupation, f => f.PickRandom(occupations));

Console.WriteLine("Only user: ");
var user = userFaker.Generate();
Console.WriteLine("- {0}", user);

Console.WriteLine("\nMany users: ");
var users = userFaker.Generate(10);
Console.WriteLine("- " + string.Join("\n- ", users));

Console.WriteLine("\nSame fake user: ");
var sameFakeUser = userFaker.UseSeed(100).Generate();
Console.WriteLine("- {0}", sameFakeUser);