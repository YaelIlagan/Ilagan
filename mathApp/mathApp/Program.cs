using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine("                        Math App                ");
            Console.Write("\n Enter first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            double Pow = Math.Pow(num1, num2);
            double Sqrt = Math.Sqrt(Pow);
            double Sign = Math.Sign(Pow);
            double exp = Math.Exp(Pow);
            double abs = Math.Abs(Pow);

            Console.WriteLine("\n The power of " + num1 + " raised to the power of " + num2 + " is :" + Pow);
            Console.WriteLine(" The Square root of " + Pow + " is : " + Sqrt);
            Console.WriteLine(" The sign of the power " + Pow + " is : " + Sign);
            Console.WriteLine(" The exponential of the power " + Pow + " is : " + exp);
            Console.WriteLine(" The absolute value of the power " + Pow + " is : " + abs);
            Console.WriteLine("\n Press any key to exit ...");




            Console.WriteLine("\n╚═══════════════════════════════════════════════════════╝");
            Console.ReadKey();
        }
    }
}
