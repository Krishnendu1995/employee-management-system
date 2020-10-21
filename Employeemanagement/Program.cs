using System;
using System.IO;

namespace Employeemanagement
{
    class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee();

            Console.WriteLine("First employee details");
            Console.WriteLine("Enter first name");
            emp1.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            emp1.LastName = Console.ReadLine();
            Console.WriteLine("Enter Employee id");
            emp1.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email id");
            emp1.EmailId = Console.ReadLine();


            employee emp2 = new employee();

            Console.WriteLine("Second  employee details");
            Console.WriteLine("Enter first name");
            emp2.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            emp2.LastName = Console.ReadLine();
            Console.WriteLine("Enter Employee id");
            emp2.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email id");
            emp2.EmailId = Console.ReadLine();


            string fileName = @"C:\Users\krish\source\repos\employee management system\Employeemanagement\output\sample.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("\t\t\t\toutput");
                writer.WriteLine("-------------------------------------------------------------------------------------------");
                writer.WriteLine("id             First name             lastname         Email");
                writer.WriteLine(emp1.EmpId + "                " + emp1.FirstName + "                   " + emp1.LastName + "            " + emp1.EmailId + "\n");
                writer.WriteLine(emp2.EmpId + "                " + emp2.FirstName + "                    " + emp2.LastName + "            " + emp2.EmailId);
            }

        }
    }
}
