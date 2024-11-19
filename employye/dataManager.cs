using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace employye
{
    class DataManager
    {
        private string _FilePath;
        public  string FilePath { get =>_FilePath ; set=> _FilePath=value; }
        public void FileCreator()
        {
            if (!File.Exists(_FilePath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(_FilePath))
                {
                    sw.WriteLine($"{"role",-50}||{"name",-20}||{"id",-20}||{"phone number",-20}||{"is mariage",-20}||{"salary",-20}");
                    sw.WriteLine("\n\n\n");
                    

                }
            }
            Console.WriteLine("this file already exist");
        }
        public void Appendlist (Employees employee,int numberofday , int overtime )
        {
            using (StreamWriter sw = File.AppendText(_FilePath))
            {
                
                sw.WriteLine($"{employee.Role(),-50}||{employee.FullName,-20}||{employee.Id,-20}||{employee.PhoneNumber,-20}||{employee.Ismariage,-20}||{employee.MonthlySalary(numberofday , overtime),-20}");
            }

        }
            // This text is always added, making the file longer over time
            // if it is not deleted.
         public void ReadFile()
        {
            using (StreamReader sr = File.OpenText(_FilePath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

            // Open the file to read from.
           
            //FileStream fs = File.Create(_FilePath);
            //fs.Close();
            //Console.WriteLine(File.Exists(_FilePath));
            //if (File.Exists(_FilePath) ==false)
            //{
            //    Console.WriteLine("exist");
            //    File.Create(_FilePath).Dispose();
            //    StreamWriter file = File.AppendText(_FilePath);
            //    file.WriteLine($"{"role",-5}{"name",-5}{"id",-50}{"phone number",-5}{"is mariage",-5}{"salary",-5}");
            //    file.Close();
            //}
            //File.Create(_FilePath).Dispose();
            //StreamWriter fle = File.AppendText(_FilePath);
            //fle.WriteLine($"{"role",-5}{"name",-5}{"id",-50}{"phone number",-5}{"is mariage",-5}{"salary",-5}");

        }


    
}
