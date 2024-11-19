using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace employye
{
    public abstract class Employees
    {

        protected int familysalery = 10;
        private string _Id ="1111111111";
        private string _PhoneNumber="00000000000";
        private string _FirstName="name" ;
        private string _LastName="family";
        private bool _IsMariage = false;
        public abstract uint employeerate { get; }
        public abstract uint Basalsalery { get; }
        public abstract uint workinghours {get; }
        public string Id {
            get
            {
                if (_Id.Length != 10)
                {
                    return $"not real becuse the length is {_Id.Length} and is not 10";
                }
                if(_Id == "0000000000")
                    return "not real";

                // Step 2: Extract the digits (first 9 digits and check digit)
                int[] digits = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    digits[i] = int.Parse(_Id[i].ToString());
                }

                // Step 3: Calculate the check digit using the algorithm
                int sum = 0;
                int[] weights = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                for (int i = 0; i < 9; i++)
                {
                    sum += digits[i] * weights[i];
                    //Console.WriteLine(sum);
                }

                int remainder = sum % 11;
                //Console.WriteLine($"{remainder}");
                //Console.WriteLine(11 - remainder);
                // Step 4: Compare the check digit with the calculated check value
                if (remainder < 2 && (digits[9] == remainder))
                {
                    //Console.WriteLine("1");
                    return _Id;
                }
                else if (remainder >=2 &&(digits[9] == (11 - remainder)))
                {
                    //Console.WriteLine("2");
                    return _Id;
                }
                else
                    return " not real";
            }
                init { _Id = value; } 
        }
        public string LastName { get=>_LastName; init=>_LastName=value; }
        public string FirstName { get=>_FirstName; init=>_FirstName=value; }
        public string FullName { get { return $"{FirstName} {LastName} "; } }
        public string PhoneNumber 
        { 
            get
            {
                if (_PhoneNumber[0] == '0' && _PhoneNumber[1] == '9' && _PhoneNumber.Length ==11 )
                {
                    return _PhoneNumber;
                }
                return $"the number :{_PhoneNumber} not real number ";
            }
            init=> _PhoneNumber= value; 
        }
        public bool Ismariage { get=>_IsMariage; init=>_IsMariage = value; }

        public virtual double MonthlySalary(int NumberOfday, int OvertimeHourse)
        {
            return Convert.ToUInt32(Ismariage) * 100;
        }
        public abstract string Role();
        public override string ToString()
        {
            return $"{FullName} : {Role()} and he/she work :{workinghours} ";
        }
    }
    public class SimpleEmployee : Employees
    {
        public override uint Basalsalery =>40;
        public override uint employeerate => 2;
        public override uint workinghours => 12;
        public override double MonthlySalary(int NumberOfday, int OvertimeHourse)
        {
            if (NumberOfday >= 30 ) 
                throw new NotImplementedException("thats impossible you cant work all the month");
            
            
            
            return base.MonthlySalary(NumberOfday ,OvertimeHourse) + OvertimeHourse * Basalsalery * employeerate ;
        }
        
        public override string Role() => "Simple Emploee: Task A, Task B";
        
    }
    public class ServiceEmployee : Employees
    {
        public override uint Basalsalery => 30;
        public override uint employeerate => 1;
        public override uint workinghours => 12;
        public override double MonthlySalary(int NumberOfday, int OvertimeHourse)
        {
            if (NumberOfday >= 30)
                throw new NotImplementedException("thats impossible you cant work all the month");
            


            return base.MonthlySalary(NumberOfday, OvertimeHourse) + OvertimeHourse * Basalsalery * employeerate  ;
        }
        public override string Role() => "Service Emploee: Nezafat";
        

    }
    public class ManagerEmployee : Employees
    {
        public override uint Basalsalery => 60;
        public override uint employeerate => 4;
        public override uint workinghours => 10;
        public override double MonthlySalary(int NumberOfday, int OvertimeHourse)
        {
            if (NumberOfday >= 30)
                throw new NotImplementedException("thats impossible you cant work all the month");
            


            return base.MonthlySalary(NumberOfday, OvertimeHourse) + OvertimeHourse * Basalsalery * employeerate ;
        }
        
        public override string Role() => "Manager Emploee: Team Lead";

    }
    public class CEOEmployee : Employees
    {
        public override uint Basalsalery => 100;
        public override uint employeerate => 6;
        public override uint workinghours => 8;
        public override double MonthlySalary(int NumberOfday, int OvertimeHourse)
        {
            if (NumberOfday >= 30)
                throw new NotImplementedException("thats impossible you cant work all the month");
            


            return base.MonthlySalary(NumberOfday, OvertimeHourse) + OvertimeHourse * Basalsalery * employeerate ;
        }
        
        public override string Role() => "CEO: Company Lead";

    }


    
}

