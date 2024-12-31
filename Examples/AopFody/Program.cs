using System;
using ExampleAopFody;
using ExampleAopFody.Attributes;

[assembly: Log]

int weeklyHours;
int weeksPerYear;
decimal hourlyPay;
decimal monthlySalary;
decimal yearlySalary;

const decimal TAX_RATE = 0.20m;

Console.WriteLine("Welcome to Salary Calculator!");
Console.WriteLine("Please enter the following information:");

Console.WriteLine("Hourly pay: $");
hourlyPay = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Hours worked each week: ");
weeklyHours = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Weeks worked each year: ");
weeksPerYear = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nThank You.");

var employerCalculator = new EmployerCalculator();
try
{
    monthlySalary = employerCalculator.MonthlySalary(hourlyPay, weeklyHours, TAX_RATE);
    yearlySalary = employerCalculator.YearSalary(hourlyPay, weeklyHours, weeksPerYear, TAX_RATE);
}
catch (Exception ex)
{
    throw ex;
}

Console.WriteLine("Monthly salary: {0:C} \nYearly salary: {1:C}", monthlySalary, yearlySalary);