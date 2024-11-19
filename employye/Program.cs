using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using employye;
bool iscontinue =true;
int overtime = 0 , numberofday =0;


Employees employee;
for (int i = 1;i<5;i++)
{
    employee = EmployeeFactory.SetEmployee(i);
    Console.WriteLine(employee.ToString());
    
}
Console.WriteLine("if you wana continu and add employee press any key ");
Console.ReadKey(true);
while (iscontinue)
{
    Console.Clear();
    int type = Discreaption.GetEmployeeType();
    employee = EmployeeFactory.emfactory(type);
    Discreaption.GetWorkData(out numberofday, out overtime);
    Console.Clear();
    Console.WriteLine("DO YOU WANA SEE EMPLOYEE DATA ");
    if (Discreaption.GetYorN())
        Discreaption.ShowDescreptin(employee,type);     
    Console.WriteLine("do you wana add another emplioyee data");
        iscontinue= Discreaption.GetYorN();
}
Environment.Exit(0);

enum EmType
{
    simple,
    manager,
    ceo,
    service
}

