using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAverageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total_grade = 0;

            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("                   Compute Average App                ");
            Console.WriteLine("\n Enter 5 grades");
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write(" Grade " + (i+1) + " : ");
                total_grade += Convert.ToDouble(Console.ReadLine());
            }

            double average = total_grade / 5;
            int round_off = Convert.ToInt32(average);

            Console.WriteLine("\n The average is: " + average + " and round off to " + round_off);
            Console.WriteLine("\n Press any key to exit...");
            
            Console.WriteLine("\n╚════════════════════════════════════════════════════════╝");
            Console.ReadKey();
        }
    }
}
