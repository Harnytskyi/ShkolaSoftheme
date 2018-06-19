using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            
            var obj = new LinkedList<int>(array);

            Console.Write("Source array: ");
            obj.PrintNumbers(array);
            obj.AddElement( 6, 7, 8, 9, 10 );

            Console.Write("Array lenght after added new elements: ");
            Console.WriteLine(obj.Lenght());

            obj.DeleteElement(6);
            Console.Write("Array deleted element: ");
            Console.WriteLine(obj.Lenght());

            Console.Write("Is there a given element in the array? ");
            Console.WriteLine(obj.Equals(5));

            int[] array2 = obj.ToArray();
            Console.Write("Result array: ");
            obj.PrintNumbers(array2);

            Console.ReadKey();
        }
        
    }
}
