using Bogus;

var faker = new Faker();

var firstNameFaker = faker.Person.FirstName;
var lastNameFaker = faker.Person.LastName;
var emailFaker = faker.Person.Email;
var phoneFaker = faker.Person.Phone;
var websiteFaker = faker.Person.Website;

Console.WriteLine($"{firstNameFaker} {lastNameFaker} {emailFaker} {phoneFaker} {websiteFaker}");