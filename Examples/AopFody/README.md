# 1. What is this project

This is a simple project that demonstrates the use of the Fody library for handling Aspect-Oriented Programming (AOP) to manipulate the IL of an assembly.

I'm using the attribute to mark that my method will be logged when my project is running.

# 2. Project type `console`

.NET 6

# 3. Output result

```
Welcome to Salary Calculator!
Please enter the following information:
Hourly pay: $
10
Hours worked each week:
40
Weeks worked each year:
5

Thank You.
OnEntry -> MonthlySalary
OnExit -> MonthlySalary
OnEntry -> YearSalary
OnExit -> YearSalary
Monthly salary: R$ 0,80
Yearly salary: R$ 1.600,00
```
