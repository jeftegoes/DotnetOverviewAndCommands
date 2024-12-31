namespace ExampleAopFody
{
    public class EmployerCalculator
    {
        public decimal MonthlySalary(decimal hourlyPay, int weeklyHours, decimal taxRate)
        {
            return (hourlyPay / (decimal)weeklyHours) * 4m * (1 - taxRate);
        }

        public decimal YearSalary(decimal hourlyPay, int weeklyHours, int weeksPerYear, decimal taxRate)
        {
            return (hourlyPay * (decimal)weeklyHours) * (decimal)weeksPerYear * (1 - taxRate);
        }
    }
}