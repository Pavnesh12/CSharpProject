// See https://aka.ms/new-console-template for more information
Console.WriteLine("Employee check present or absent");
int employeeFullTime = 1;
int employeePartTime = 2;
int empHour = 0;
int empWagePerHour = 20;
int empWage = 0;
Random random = new Random();
int empcheck = random.Next(0, 3);
if (empcheck == employeeFullTime)
{
    Console.WriteLine("Employee is present work as full time");
    empHour = 8;
}
 else if (empcheck == employeePartTime)
{
    Console.WriteLine("Employee is present and work as Part time ");
    empHour = 4;
}
else
{
    Console.WriteLine("Employee is absent");
    empHour = 0;
}
empWage = empWagePerHour * empHour;
Console.WriteLine("Employee wage is =" + empWage);

