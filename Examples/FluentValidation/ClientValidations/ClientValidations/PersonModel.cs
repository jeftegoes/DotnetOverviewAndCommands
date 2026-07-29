namespace ClientValidations
{
    public class PersonModel
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public decimal AccountBalance { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
