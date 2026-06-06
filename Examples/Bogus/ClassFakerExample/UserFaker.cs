using Bogus;

public class UserFaker : Faker<User>
{
    public UserFaker()
    {
        RuleFor(u => u.Name, f => f.Name.FullName());
        RuleFor(u => u.Age, f => (DateTime.Now.Year - f.Person.DateOfBirth.Year));
        RuleFor(u => u.DateBirth, f => f.Person.DateOfBirth);
    }
}