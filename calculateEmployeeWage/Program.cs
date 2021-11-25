// See https://aka.ms/new-console-template for more information
Console.WriteLine("Employee check full time present, part time present or absent");
int employeeFullTime = 1;
int employeePartTime = 2;
int empHour = 0;
int empWagePerHour = 20;
int empWage = 0;
Random random = new Random();
int empcheck = random.Next(0, 3);
switch(empcheck)

{
    case 0:
        Console.WriteLine("employee  absent");
        empHour = 0;
        break;
    
    case 1:
        Console.WriteLine("employee  prsent FullTime");
        empHour = 8;
        break;
    default:
        Console.WriteLine("employee PartTime" );
        empHour = 4;
        break;
}


empWage = empWagePerHour * empHour;
Console.WriteLine("Employee wage is =" + empWage);

