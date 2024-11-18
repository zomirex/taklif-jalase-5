using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace employye
{
    public class Employees
    {
        protected int familysalery = 10;
        private int _Basalsalery =10  ;
        private string _Id ="1111111111";
        private string _PhoneNumber="00000000000";
        private string _FirstName="name" ;
        private string _LastName="family";
        private bool _IsMariage = false;
        public int Basalsalery { get =>_Basalsalery; set=>_Basalsalery=value; }
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
        
        public virtual double MonthlySalary (int NumberOfday, int OvertimeHourse  )
        {
            throw new NotImplementedException();
        }
    }
    public class SimpleEmployee : Employees
    {
        
        private int employeerate = 1;
        private int workinghours = 10;
        public override double MonthlySalary(int NumberOfday, int OvertimeHourse)
        {
            int mariage = 0;
            if (Ismariage==true)
                mariage = 1;
            double salery = NumberOfday * workinghours *Basalsalery + OvertimeHourse * Basalsalery * employeerate +  mariage * familysalery ;
            return salery;
        }
    }
    public class ServiceEmployee : Employees
    {
        private int employeerate = 1;
        private int workinghours = 12;
        public override double MonthlySalary(int NumberOfday, int OvertimeHourse)
        {
            int mariage = 0;
            if (Ismariage == true)
                mariage = 1;
            double salery = NumberOfday * workinghours * Basalsalery + OvertimeHourse * Basalsalery * employeerate + mariage * familysalery;
            return salery;
        }

    }
    public class ManagerEmployee : Employees
    {
        private int employeerate = 2;
        private int workinghours = 8;
        public override double MonthlySalary(int NumberOfday, int OvertimeHourse)
        {
            int mariage = 0;
            if (Ismariage == true)
                mariage = 1;
            double salery = NumberOfday * workinghours * Basalsalery + OvertimeHourse * Basalsalery * employeerate + mariage * familysalery;
            return salery;
        }

    }
    public class CEOEmployee : Employees
    {
        private int employeerate = 3;
        private int workinghours = 10;
        public override double MonthlySalary(int NumberOfday, int OvertimeHourse)
        {
            int mariage = 0;
            if (Ismariage == true)
                mariage = 1;
            double salery = NumberOfday * workinghours * Basalsalery + OvertimeHourse * Basalsalery * employeerate + mariage * familysalery;
            return salery;
        }

    }
    public class NotificationService
    {
        // Virtual method for showing a basic toast
        public virtual void Toast(string message)
        {
            // Default behavior: Just print the message
            Console.WriteLine("Base class toast: " + message);
        }
    }


    
}

