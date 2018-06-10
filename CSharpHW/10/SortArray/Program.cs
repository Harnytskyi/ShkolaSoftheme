using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { 4, 8, 6, 2, 40, 18, 54, 3 };
            SortArray(mass);
            foreach(int i in mass) 
            Console.Write("{0} ", i);
            Console.ReadKey();
        }
        public static void SortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        int buf = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = buf;

                    }
            }
        }
    }
}
