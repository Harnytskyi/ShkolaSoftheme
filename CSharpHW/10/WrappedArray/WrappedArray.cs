using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrappedArray
{
    public class WrappedArray
    {
        int[] Array1 { get; set; }

        public WrappedArray(params int[] arguments)
        {
            Array1 = arguments;
        }
        public void Add(params int [] arguments)
        {
            var newArray = new int[Array1.Length + arguments.Length];
            Array1.CopyTo(newArray, 0);
            arguments.CopyTo(newArray, Array1.Length);
            Array1 = newArray;
        }

        public bool Contains(int value)
        {
            foreach (int i in Array1)
            {
                if (i == value)
                    return true;
            }
            return false;
        }

        public int GetByIndex(int index)
        {
            return Array1[index];
        }

        public override string ToString()
        {
            string result = string.Empty;
            foreach (int item in Array1)
            {
                result += item.ToString() + " ";
            }
            return result;
        }
    }
}
