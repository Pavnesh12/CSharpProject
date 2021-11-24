// See https://aka.ms/new-console-template for more information
Console.WriteLine("Employee check present or absent");
int employeePresent = 1;
Random random = new Random();
int empcheck = random.Next(0, 2);
Console.WriteLine(empcheck);
if(empcheck == employeePresent)
{
    Console.WriteLine("Employee is present ");

}
else
{
    Console.WriteLine("Employee is absent");
}