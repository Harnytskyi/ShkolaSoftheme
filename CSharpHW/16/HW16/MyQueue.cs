using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW16
{
    class MyQueue<T>
    {
        private T[] InnerQueue;

        public MyQueue(params T[] elements)
        {
                InnerQueue = elements; 
        }

        public void Enqueue(T element)
        {
            var newSize = InnerQueue.Length + 1;
            var newArray = new T[newSize];
            Array.Copy(InnerQueue, newArray, InnerQueue.Length);
            InnerQueue = newArray;
            InnerQueue[InnerQueue.Length - 1] = element;
        }

        public T Dequeue()
        {
            var dequeued = InnerQueue[0];
            var newSize = InnerQueue.Length - 1;
            var newArray = new T[newSize];
            for (int i = 0; i<newSize; i++)
            {
                newArray[i] = InnerQueue[i + 1];
            }
            InnerQueue = newArray;
            return dequeued;
        }

        public T Peek()
        { 
            return InnerQueue[0];
        }

        public void Print()
        {
            foreach(var i in InnerQueue)
                Console.Write(i + ", ");
            Console.WriteLine();
        }
    }
}
