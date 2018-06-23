using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW16
{
    class MyStack<T>
    {
        private T[] InnerStack;

        public MyStack(params T[] elements)
        {
            InnerStack = elements;
        }
        public void Push(T element)
        {
            var newSize = InnerStack.Length + 1;
            var newArray = new T[newSize];
            newArray[0] = element;
            for (int i=1; i<newSize; i++)
            {
                newArray[i] = InnerStack[i-1];
            }
            InnerStack = newArray;
        }

        public T Pop()
        {
            var pop = InnerStack[0];
            var newSize = InnerStack.Length - 1;
            var newArray = new T[newSize];
            for (int i = 0; i < newSize; i++)
            {
                newArray[i] = InnerStack[i + 1];
            }
            InnerStack = newArray;
            return pop;
        }

        public T Peek()
        {
            return InnerStack[0];
        }

        public void Print()
        {
            foreach (var i in InnerStack)
                Console.Write(i + ", ");
            Console.WriteLine();
        }
    }
}
