using Bogus;

var fakerPtBr = new Faker("pt_BR");

var firstNamePtBrFaker = fakerPtBr.Person.FirstName;
var lastNamePtBrFaker = fakerPtBr.Person.LastName;
var emailPtBrFaker = fakerPtBr.Person.Email;

Console.WriteLine($"Brazilian: {firstNamePtBrFaker} {lastNamePtBrFaker} {emailPtBrFaker}");

var fakerSk = new Faker("sk");

var firstNameSkFaker = fakerSk.Person.FirstName;
var lastNameSkFaker = fakerSk.Person.LastName;
var emailSkFaker = fakerSk.Person.Email;

Console.WriteLine($"Slovakian: {firstNameSkFaker} {lastNameSkFaker} {emailSkFaker}");

var fakerEs = new Faker("es");

var firstNameEsFaker = fakerEs.Person.FirstName;
var lastNameEsFaker = fakerEs.Person.LastName;
var emailEsFaker = fakerEs.Person.Email;

Console.WriteLine($"Spanish: {firstNameEsFaker} {lastNameEsFaker} {emailEsFaker}");