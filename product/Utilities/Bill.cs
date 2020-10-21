using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace product.Utilities
{
    public class Bill
    {
        public string GenerateBill(int id1, string brand1, string name1, int qty1, int price1)
        {
            Random rn = new Random();
            int no = rn.Next(1000, 2000);
            string path = Directory.GetCurrentDirectory();
            string filename = @"C:\Users\hp\Source\Repos\employee-management-system\product\Billreport\" + "ozreport"+no+".txt";
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("\t\t\t\toutput");
                writer.WriteLine("-------------------------------------------------------------------------------------------");
                writer.WriteLine("id                Brandname                Name           Quantity            Price");
                writer.WriteLine(id1 + "                " + brand1 + "                     " + name1 + "              " + qty1 + "             " + price1);
              
            }
            return filename;
        }
    }

    
}
