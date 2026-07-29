using ClientValidations.Validators;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ClientValidations
{
    public partial class Form1 : Form
    {
        private BindingList<string> errors = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();
            errosListBox.DataSource = errors;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            errors.Clear();

            if (!decimal.TryParse(accountBalanceText.Text, out decimal accountBalance))
            {
                errors.Add("Account balance: Invalid Amount");
                return;
            };

            var person = new PersonModel()
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                AccountBalance = accountBalance,
                DateOfBirth = dateOfBirthPicker.Value
            };

            var personValidator = new PersonValidator();
            var results = personValidator.Validate(person);

            if (results.IsValid == false)
            {
                foreach (var failure in results.Errors)
                {
                    errors.Add($"{failure.PropertyName}: {failure.ErrorMessage}");
                }
                return;
            }

            MessageBox.Show("Operation complete.");
        }
    }
}