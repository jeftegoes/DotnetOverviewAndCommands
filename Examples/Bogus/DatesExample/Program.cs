using Bogus;

var now = DateTime.Now;
var faker = new Faker();
Console.WriteLine("Future: {0}", faker.Date.Future(5));
Console.WriteLine("Present: {0}", now);
Console.WriteLine("Past: {0}", faker.Date.Past(32));
Console.WriteLine("Date between two dates: {0}", faker.Date.Between(new DateTime(1991, 1, 1), new DateTime(2016, 1, 1)));