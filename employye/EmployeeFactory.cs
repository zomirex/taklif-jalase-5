using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employye
{
    public static class Discreaption
    {
        public static int GetEmployeeType()
        {
            Console.WriteLine("please enter \r\n1 for simple employee\r\n2 for manager employee\r\n3 for ceo employee");
            while(true)
            {
                int employeetype = Convert.ToInt32(Discreaption.Getnumber("Employee type"));

                if (employeetype == 1 || employeetype ==2 || employeetype == 3 )
                {    
                    Console.Clear();
                    return employeetype;
                }
                else 
                     Console.WriteLine($"please enter right number you enter : {employeetype}");
  
            }

        }
        public static void  GetWorkData (out int numberofday , out int overtime)
        {
            numberofday = 0;
            overtime = 0;
            numberofday=Convert.ToInt32(Discreaption.Getnumber("how many days are you working"));
            overtime = Convert.ToInt32(Discreaption.Getnumber("how many hourse are you worked over time"));
            return;
        }
        public static bool GetYorN()
        {
            while (true)
            {

                Console.WriteLine("**********\tplease press Y :for yes\tor\tpress  N : for no\t************");
                char input = char.MinValue;
                input = char.ToUpper(Console.ReadKey(true).KeyChar);
                if (input == 'Y')
                {
                    return true;
                }
                else if (input == 'N')
                {
                    return false;

                }



            }
        }
        public static string Getname(string name)
        {
            
            Console.WriteLine($"**************\tplease enter {name}\t************** ");
            char R = 'a';
            string result = "";
            int validate = 0;
            do
            {

                R = Console.ReadKey(true).KeyChar;

                while ( (R>96 && R <123)||(R>64&&R<91)  )
                {
                    result = result + R;
                    
                    R = Console.ReadKey(true).KeyChar;

                    validate++;
                }
                //Console.WriteLine(result);

                if ((R != '+' || R != '-' ) && validate > 0)
                {
                    Console.WriteLine($"is  your {name}?????  {result}  \n\r if it is prees + \n\r if not press -");

                    R = Console.ReadKey(true).KeyChar;

                }
                if ((R == '+') && validate > 0)
                    break;
                else if ((R == '-' || R == '-') && validate > 0)
                {
                    result = "";
                    validate = 0;
                    Console.WriteLine($"*********please enter {name} again********");
                }

            } while (R != '+' );

           
            return result;
        }
        public static string Getnumber(string name)
        {


            Console.WriteLine($"**************\tplease enter {name}\t************** ");
            char R = 'a';

            string result = "";
            int validate = 0;
            do
            {

                R = Console.ReadKey(false).KeyChar;

                while (char.IsNumber(R))
                {
                    result = result + R;
                    R = Console.ReadKey(false).KeyChar;
                    validate++;
                }
                //Console.WriteLine(result);

                if ((R != '+' || R != '-') && validate > 0)
                {
                    Console.WriteLine($"is  your {name}?????  {result}  \n\r if it is prees + \n\r if not press -");

                    R = Console.ReadKey(true).KeyChar;

                }
                if ((R == '+') && validate > 0)
                    break;
                else if ((R == '-') && validate > 0)
                {
                    result = "";
                    validate = 0;
                    Console.WriteLine($"*********please enter {name} again********");
                }

            } while (R != '+' );


            return result;
        }
        public static void ShowDescreptin(Employees employee, int type )
        {   Console.ForegroundColor = ConsoleColor.Red;
            switch(type)
            {
                case 1: Console.WriteLine("\t\t Simple Employee\t\t\n");
                    break;
                case 2: Console.WriteLine("\t\t manager Employee\t\t\n");
                    break;
                case 3: Console.WriteLine("\t\t service Employee\t\t\n");
                    break;
                case 4: Console.WriteLine("\t\t CEO Employee\t\t\n");
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"employee name : {employee.FullName}");
            Console.WriteLine($"employee id : {employee.Id}");
            Console.WriteLine($"employee phonenumber : {employee.PhoneNumber}");
            Console.WriteLine($"is employee mariaged : {employee.Ismariage}");
            Console.WriteLine($"the month slaery for employee {employee.FullName} is {employee.MonthlySalary(22, 12):c}");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
    public static class EmployeeFactory
    {
        
        public static Employees emfactory (int emtype )
        {
            switch(emtype)
            {
                case 1 :
                    {
                        
                        string firstname , lastname , phonenumber ,id ;
                        firstname = Discreaption.Getname("firstname");
                        lastname = Discreaption.Getname("lastname");
                        phonenumber = Discreaption.Getnumber("phone number");
                        id = Discreaption.Getnumber("id code");
                        Console.WriteLine("are you mariaged??");
                        bool ismariage = Discreaption.GetYorN();
                        return new SimpleEmployee
                        {
                            FirstName = firstname,
                            LastName = lastname,
                            PhoneNumber = phonenumber,
                            Id = id,
                            Basalsalery = 10,
                            Ismariage = ismariage
                        };
                                       
                    }

                case 2:
                    {
                        string firstname, lastname, phonenumber, id;
                        firstname = Discreaption.Getname("firstname");
                        lastname = Discreaption.Getname("lastname");
                        phonenumber = Discreaption.Getnumber("phone number");
                        id = Discreaption.Getnumber("id code");
                        Console.WriteLine("are you mariaged??");
                        bool ismariage = Discreaption.GetYorN();
                        return new ManagerEmployee
                        {
                            FirstName = firstname,
                            LastName = lastname,
                            PhoneNumber = phonenumber,
                            Id = id,
                            Basalsalery = 10,
                            Ismariage = ismariage
                        };
                    }
                case 3:
                    {
                        string firstname, lastname, phonenumber, id;
                        firstname = Discreaption.Getname("firstname");
                        lastname = Discreaption.Getname("lastname");
                        phonenumber = Discreaption.Getnumber("phone number");
                        id = Discreaption.Getnumber("id code");
                        Console.WriteLine("are you mariaged??");
                        bool ismariage = Discreaption.GetYorN();
                        return new CEOEmployee
                        {
                            FirstName = firstname,
                            LastName = lastname,
                            PhoneNumber = phonenumber,
                            Id = id,
                            Basalsalery = 10,
                            Ismariage = ismariage
                        };
                    }
                default:
                    throw new NotImplementedException();    


            }
        }
    }
   
}
