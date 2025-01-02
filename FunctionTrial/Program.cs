using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTrial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Num1, Num2, addition, multiplication, division, subtraction;
            Console.WriteLine("1. Number: ");
            Num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("2. Number: ");
            Num2 = Convert.ToDouble(Console.ReadLine());
            addition = Num1 + Num2;
            multiplication = Num1 * Num2;
            division = Num1 / Num2;
            subtraction = Num1 - Num2;
            Console.WriteLine("{0} and {1} sum of numbers:{2}", Num1, Num2, addition);
            Console.WriteLine("{0} and {1} multiplication of numbers:{2}", Num1, Num2, multiplication);
            Console.WriteLine("{0} and {1} division of numbers:{2}", Num1, Num2, division);
            Console.WriteLine("{0} and {1} subtraction of numbers:{2}", Num1, Num2, subtraction);
            Console.ReadKey();
        }
    }
}
