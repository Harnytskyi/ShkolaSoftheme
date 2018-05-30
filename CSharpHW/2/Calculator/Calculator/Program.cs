using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First operand");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Operation");
            var operation = Console.ReadLine();
            Console.WriteLine("Second operand");
            double second = double.Parse(Console.ReadLine());
            Console.WriteLine("Result");
            calculate(first, second, operation);
            Console.ReadKey();
        }
        private static void calculate(double first, double second, string operation)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine(Math.Round(first + second, 2));
                    break;
                case "-":
                    Console.WriteLine(Math.Round(first - second, 2));
                    break;
                case "*":
                    Console.WriteLine(Math.Round(first * second, 2));
                    break;
                case "/":
                    Console.WriteLine(Math.Round(first / second, 2));
                    break;
            }
        }
    }
}
