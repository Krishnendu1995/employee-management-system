using System.IO;

namespace write_file
{
    public class Program
    {
        static void Main()
        {
            string fileName = @"C:\krish\sample.txt";
                using (StreamWriter writer = new StreamWriter("fileName"))
                {
                    writer.Write("Word ");
                    writer.WriteLine("word 2");
                    writer.WriteLine("Line");
                }

        }
    }
}
