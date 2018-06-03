using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Which figure you want printing?");
                Console.WriteLine("1 - Triangle");
                Console.WriteLine("2 - Square");
                Console.WriteLine("3 - Romb");
                Console.WriteLine("4 - Close app");
                
                int i = Int32.Parse(Console.ReadLine());
                switch (i)
                {     
                    case 1:
                        var sizeTriangle = Size();
                        PrintTriangle(sizeTriangle);
                        break;    
                    case 2:
                        var sizeSquare = Size();
                        PrintSquare(sizeSquare);
                        break;
                    case 3:
                        var sizeRomb = Size();
                        PrintRomb (sizeRomb);
                        Console.WriteLine();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        break;

                }
            }
        }
        static int Size()
        {
            Console.Write("What size should be your figure: ");
            int size = Int32.Parse(Console.ReadLine());
            return size;
        }
        
        static void PrintTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                    
                    Console.Write("* ");
                Console.WriteLine();
            }
        }
        static void PrintSquare(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }
        static void PrintRomb(int size)
        {
            int j = 1;
            int blank = size - j;
            int star = 1;
            for (; j <= size; j++)
            {
                for (int i = 1; i <= blank; i++)
                    Console.Write("  ");
                for (int i = 1; i <= star; i++)
                    Console.Write("* ");
                blank--;
                star = star + 2;
                Console.WriteLine();
            }
            
            blank = 1;
            star = star - 4;
            for (; j > 0; j--)
            {
                for (int i = 1; i <= blank; i++)
                    Console.Write("  ");
                for (int i = 1; i <= star; i++)
                    Console.Write("* ");
                blank++;
                star = star - 2;
                Console.WriteLine();

            }
        }

    }
}
