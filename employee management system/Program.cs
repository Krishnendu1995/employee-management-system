using System;

namespace employee_management_system
{
    class Program
    {
        static void Main(string[] args)
        {
            employee obj = new employee();

            Console.WriteLine("Enter Employee Name");
            obj.setName(Console.ReadLine());
            Console.WriteLine("Enter Employee Address");
            obj.setAddress(Console.ReadLine());
            Console.WriteLine("Enter Employee Age");
            obj.setAge(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter Employee salary");
            obj.setSalary(Convert.ToInt32(Console.ReadLine()));


            Console.WriteLine(obj.getName());
            Console.WriteLine(obj.getAddress());
            Console.WriteLine(obj.getAge());
            Console.WriteLine(obj.getSalary());

        }
    }
}
