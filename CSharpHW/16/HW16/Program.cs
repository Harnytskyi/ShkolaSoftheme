using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--- QUEUE ---");
            Console.ResetColor();

            var Fruit = new MyQueue<string>("strawberry", "cherry", "melon" );
            Fruit.Print();
            Fruit.Enqueue("apple");
            Fruit.Print();
            Console.WriteLine(Fruit.Dequeue());
            Fruit.Print();
            Console.WriteLine(Fruit.Peek());
            Fruit.Print();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--- STACK ---");
            Console.ResetColor();

            var Phone = new MyStack<string>("Nokia", "HTC", "Samsung");
            Phone.Print();
            Phone.Push("Meizu");
            Phone.Print();
            Console.WriteLine(Phone.Peek());
            Phone.Print();
            Console.WriteLine(Phone.Pop());
            Phone.Print();
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--- DICTIONARY ---");
            Console.ResetColor();

            var dictionary = new MyDictionary<int, string>();
            dictionary.Add(4, "Hardwell");
            dictionary.Add(7, "David");
            dictionary.Add(5, "Tiesto");
            dictionary.Print();
            Console.WriteLine();

            try
            {    
            dictionary.Add(5, "Omnia");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Exception caught. {0}", ex.Message);
            }
            
            try
            {
                dictionary.Remove(6);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Exception caught. {0}", ex.Message);
            }
            
            dictionary.Add(1, "Martin");
            dictionary.Remove(7);
            dictionary.Print();
            Console.WriteLine();

            dictionary.Sorted();
            dictionary.Print();

            Console.ReadKey();
        }
    }
}
