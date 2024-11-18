using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using employye;


Employees employee;
employee = new SimpleEmployee
{
    FirstName = "amir",
    LastName = "naseh ",
    Id = "1630414654",
    PhoneNumber = "09195777354",
    Ismariage = false,
    


};
Console.WriteLine(employee.FullName);
Console.WriteLine(employee.Id);
Console.WriteLine(employee.PhoneNumber);
Console.WriteLine(employee.Ismariage);
Console.WriteLine($"the month slaery for employee {employee.FullName} is {employee.MonthlySalary(22, 6):c}");
employee = new SimpleEmployee
{
    FirstName = "mmdali",
    LastName = "naseh ",
    Id = "1635539811",
    PhoneNumber = "09335353290",
    Ismariage = true,
    


};
Console.WriteLine(employee.FullName);
Console.WriteLine(employee.Id);
Console.WriteLine(employee.PhoneNumber);
Console.WriteLine(employee.Ismariage);
Console.WriteLine($"the month slaery for employee {employee.FullName} is {employee.MonthlySalary(22, 6):c}");



