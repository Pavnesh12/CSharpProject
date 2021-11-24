// See https://aka.ms/new-console-template for more information
Console.WriteLine("Employee check present or absent");
int employeePresent = 1;
int empHour = 0;
int empWagePerHour = 20;
int empWage = 0;
Random random = new Random();
int empcheck = random.Next(0, 2);
if (empcheck == employeePresent)
{
    Console.WriteLine("Employee is present");
    empHour = 8;
}
else
{
    Console.WriteLine("Employee is absent");
    empHour = 0;
}
empWage = empWagePerHour * empHour;
Console.WriteLine("Employee wage is =" + empWage);

