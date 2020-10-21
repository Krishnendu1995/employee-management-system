using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace productdetails
{
    class Program
    {
        static void Main(string[] args)
        {
            product pro1 = new product();

            Console.WriteLine("First Product details");
            Console.WriteLine("Enter first productid");
            pro1.ProId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name of the product");
            pro1.Name = Console.ReadLine();
            Console.WriteLine("Enter the price of the product");
            pro1.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity of the product");
            pro1.Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Discount");
            pro1.Discount = Convert.ToInt32(Console.ReadLine());
            int Final = Convert.ToInt32(pro1.disco());


            product pro2 = new product();

            Console.WriteLine("Second Product details");
            Console.WriteLine("Enter second productid");
            pro2.ProId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name of the product");
            pro2.Name = Console.ReadLine();
            Console.WriteLine("Enter the price of the product");
            pro2.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity of the product");
            pro2.Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Discount");
            pro2.Discount = Convert.ToInt32(Console.ReadLine());
            int Finals = Convert.ToInt32(pro2.disco());





            product pro3 = new product();

            Console.WriteLine("Third Product details");
            Console.WriteLine("Enter third productid");
            pro3.ProId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name of the product");
            pro3.Name = Console.ReadLine();
            Console.WriteLine("Enter the price of the product");
            pro3.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity of the product");
            pro3.Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Discount");
            pro3.Discount = Convert.ToInt32(Console.ReadLine());
            int Finalss = Convert.ToInt32(pro3.disco());



            string path = Directory.GetCurrentDirectory();
            string filename = @path + "sample.txt";
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("\t\t\t\toutput");
                writer.WriteLine("-------------------------------------------------------------------------------------------");
                writer.WriteLine("id                Name                Price           Quantity");
                writer.WriteLine(pro1.ProId + "                " + pro1.Name + "                     " + pro1.Price + "              " + pro1.Quantity +"             "+pro1.Discount+"            "+Final+ "\n");
                writer.WriteLine(pro2.ProId + "                " + pro2.Name + "                    " + pro2.Price + "            " + pro2.Quantity + "             " + pro2.Discount + "            " + Finals + "\n");
                writer.WriteLine(pro3.ProId + "                " + pro3.Name + "                    " + pro3.Price + "              " + pro3.Quantity+"             " + pro3.Discount + "            " + Finalss );
            }
            string notepadPath = Environment.SystemDirectory + "\\notepad.exe";

            var startInfo = new ProcessStartInfo(notepadPath)
            {
                WindowStyle = ProcessWindowStyle.Maximized,
                Arguments = filename
            };

            Process.Start(startInfo);

        }
    }
}
       
    

