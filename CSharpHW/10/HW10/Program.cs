using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = CreateMass();
            Console.WriteLine(FindAloneNumber(mass));
            
            Console.ReadLine();
        }

        public static int[] CreateMass()
        {
            int[] arr = new int[1001];
            for(int i=0; i<(arr.Length-1)/2; i++)
            {
                arr[i] = i;
                arr[i + 501] = i;
            }
            arr[500] = 777;
            return arr;
        }
        public static int FindAloneNumber(int[] arr)
        {
            int result = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                result = result ^ arr[i];
            }
            return result;
        }
    }
}